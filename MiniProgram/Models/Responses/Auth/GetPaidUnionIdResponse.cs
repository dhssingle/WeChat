using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.Responses.Auth
{
    public class GetPaidUnionIdResponse : CommonResponse
    {
        /// <summary>
        /// 用户唯一标识，调用成功后返回
        /// </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; }
    }
}