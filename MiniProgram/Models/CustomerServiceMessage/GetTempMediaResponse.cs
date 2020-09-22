using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.CustomerServiceMessage
{
    public class GetTempMediaResponse : CommonResponse
    {
        /// <summary>
        /// 数据类型 (MIME Type)
        /// </summary>
        [JsonProperty("contentType")]
        public string ContentType { get; set; }
        /// <summary>
        /// 数据 Buffer
        /// </summary>
        [JsonProperty("buffer")]
        public byte[] Buffer { get; set; }
    }
}