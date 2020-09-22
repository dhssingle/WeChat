using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.CustomerServiceMessage
{
    public class UploadTempMediaRequest : CommonRequest
    {
        public UploadTempMediaRequest(string type, FileStream media)
        {
            httpMethod = HttpMethod.Post;
            requestUri = "cgi-bin/media/upload?";

            Type = type;
            Media = media;
        }
        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("media")]
        public FileStream Media { get; }
    }
}