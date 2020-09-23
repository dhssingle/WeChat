using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class GetPubTemplateKeyWordsByIdRequest : CommonRequest
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="TId">模板标题 id，可通过接口获取</param>
        public GetPubTemplateKeyWordsByIdRequest(string tId)
        {
            httpMethod = System.Net.Http.HttpMethod.Get;
            requestUri = "wxaapi/newtmpl/getpubtemplatekeywords";

            TId = tId;
        }

        /// <summary>
        /// 模板标题 id，可通过接口获取
        /// </summary>
        [JsonProperty("TId")]
        public string TId { get; }
    }
}