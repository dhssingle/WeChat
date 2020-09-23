using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.UpdatableMessage
{
    public class CreateActivityIdResponse : CommonResponse
    {
        /// <summary>
        /// 动态消息的 ID
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }
        /// <summary>
        /// activity_id 的过期时间戳。默认24小时后过期。
        /// </summary>
        [JsonProperty("expiration_time")]
        public long ExpirationTime { get; set; }
    }
}