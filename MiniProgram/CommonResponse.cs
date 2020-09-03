using Newtonsoft.Json;

namespace WeChat.MiniProgram
{
    public class CommonResponse : IResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("errmsg")]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("errcode")]
        public int ErrorCode { get; set; }
    }
}