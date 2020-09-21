using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.Requests.UniformMessage
{
    public class UniformSendRequest : CommonRequest
    {
        public UniformSendRequest(string toUser, WeappTemplateMsg weappTemplateMsg, MpTemplateMsg mpTemplateMsg)
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "cgi-bin/message/wxopen/template/uniform_send";

            ToUser = toUser;
            WeappTemplateMsg = weappTemplateMsg;
            MpTemplateMsg = mpTemplateMsg;
        }
        /// <summary>
        /// 用户openid，可以是小程序的openid，也可以是mp_template_msg.appid对应的公众号的openid
        /// </summary>
        [JsonProperty("touser")]
        public string ToUser { get; }
        /// <summary>
        /// 小程序模板消息相关的信息，可以参考小程序模板消息接口; 
        /// 有此节点则优先发送小程序模板消息
        /// </summary>
        [JsonProperty("weapp_template_msg")]
        public WeappTemplateMsg WeappTemplateMsg { get; }
        /// <summary>
        /// 公众号模板消息相关的信息，可以参考公众号模板消息接口；
        /// 有此节点并且没有weapp_template_msg节点时，发送公众号模板消息
        /// </summary>
        [JsonProperty("mp_template_msg")]
        public MpTemplateMsg MpTemplateMsg { get; set; }
    }

    public class WeappTemplateMsg
    {
        /// <summary>
        /// 小程序模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
        /// <summary>
        /// 小程序页面路径
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }
        /// <summary>
        /// 小程序模板消息formid
        /// </summary>
        [JsonProperty("form_id")]
        public string FormId { get; set; }
        /// <summary>
        /// 小程序模板数据
        /// </summary>
        [JsonProperty("data")]
        public Dictionary<string, Dictionary<string, string>> Data { get; set; }
        /// <summary>
        /// 小程序模板放大关键词
        /// </summary>
        [JsonProperty("emphasis_keyword")]
        public string EmphasisKeyword { get; set; }
    }

    public class MpTemplateMsg
    {
        /// <summary>
        /// 公众号appid，要求与小程序有绑定且同主体
        /// </summary>
        [JsonProperty("appid")]
        public string Appid { get; set; }
        /// <summary>
        /// 公众号模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
        /// <summary>
        /// 公众号模板消息所要跳转的url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        /// <summary>
        /// 公众号模板消息所要跳转的小程序，小程序的必须与公众号具有绑定关系
        /// </summary>
        [JsonProperty("miniprogram")]
        public Miniprogram Miniprogram { get; set; }
        /// <summary>
        /// 公众号模板消息的数据
        /// </summary>
        [JsonProperty("data")]
        public Dictionary<string, Dictionary<string, string>> Data { get; set; }
    }

    public class Miniprogram
    {
        [JsonProperty("appid")]
        public string Appid { get; set; }

        [JsonProperty("pagepath")]
        public string Pagepath { get; set; }
    }
}


