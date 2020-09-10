using System.Net.Http;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.CustomerServiceMessageApi
{
    public class GetTempMediaRequest : CommonRequest
    {
        public GetTempMediaRequest()
        {
            httpMethod = HttpMethod.Get;
            requestUri = "cgi-bin/media/get?";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediaId">媒体文件 ID</param>
        public GetTempMediaRequest(string mediaId)
        {
            MediaId = mediaId;
        }
        /// <summary>
        /// 媒体文件 ID
        /// </summary>
        [JsonProperty("media_id")]
        public string MediaId { get; }
    }
}