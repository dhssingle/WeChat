using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class AddTemplateRequest : CommonRequest
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="TId">模板标题 id，可通过接口获取，也可登录小程序后台查看获取</param>
        /// <param name="kidList">开发者自行组合好的模板关键词列表，关键词顺序可以自由搭配（例如 [3,5,4] 或 [4,5,3]），最多支持5个，最少2个关键词组合</param>
        /// <param name="sceneDesc">服务场景描述，15个字以内</param>
        public AddTemplateRequest(string TId, IEnumerable<int> kidList, string sceneDesc = null)
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "wxaapi/newtmpl/addtemplate";

            TId = TId;
            KidList = kidList;
            SceneDesc = sceneDesc;
        }
        /// <summary>
        /// 模板标题 id，可通过接口获取，也可登录小程序后台查看获取
        /// </summary>
        [JsonProperty("TId")]
        public string TId { get; }
        /// <summary>
        /// 开发者自行组合好的模板关键词列表，关键词顺序可以自由搭配（例如 [3,5,4] 或 [4,5,3]），最多支持5个，最少2个关键词组合
        /// </summary>
        [JsonProperty("kidList")]
        public IEnumerable<int> KidList { get; }
        /// <summary>
        /// 服务场景描述，15个字以内
        /// </summary>
        [JsonProperty("sceneDesc")]
        public string SceneDesc { get; }
    }
}