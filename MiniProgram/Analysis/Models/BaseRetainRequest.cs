using System.Net.Http;
using Newtonsoft.Json;

namespace WeChat.MiniProgram
{
    public class BaseRetainRequest : CommonRequest
    {
        /// <summary>
        /// 开始日期。格式为 yyyymmdd
        /// </summary>
        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束日期。格式为 yyyymmdd
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}
