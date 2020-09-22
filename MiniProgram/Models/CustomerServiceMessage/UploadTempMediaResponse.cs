using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.CustomerServiceMessage
{
    public class UploadTempMediaResponse : CommonResponse
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 媒体文件上传后，获取标识，3天内有效。
        /// </summary>
        [JsonProperty("media_id")]
        public string MediaId { get; set; }
        /// <summary>
        /// 媒体文件上传时间戳
        /// </summary>
        /// <value></value>
        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
    }

}