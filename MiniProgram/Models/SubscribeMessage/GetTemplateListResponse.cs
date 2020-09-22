using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class GetTemplateListResponse : CommonResponse
    {
        /// <summary>
        /// 添加至帐号下的模板 id，发送小程序订阅消息时所需
        /// </summary>
        [JsonProperty("priTmplId")]
        public string PriTmplId { get; set; }
        /// <summary>
        /// 模版标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 模版内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
        /// <summary>
        /// 模板内容示例
        /// </summary>
        [JsonProperty("example")]
        public string Example { get; set; }
        /// <summary>
        /// 模板内容示例
        /// </summary>>
        [JsonProperty("type")]
        public int Type { get; set; }
    }
}