using System.Net.Http;
using Newtonsoft.Json;

namespace WeChat.MiniProgram
{
    public class GetDailyRetainRequest : CommonRequest
    {
        public GetDailyRetainRequest()
        {
            httpMethod = HttpMethod.Post;
            requestUri = "datacube/getweanalysisappiddailyretaininfo?";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beginDate">开始日期。格式为 yyyymmdd</param>
        /// <param name="endDate">结束日期，限定查询1天数据，允许设置的最大值为昨日。格式为 yyyymmdd</param>
        /// <returns></returns>
        public GetDailyRetainRequest(string beginDate, string endDate):this()
        {
            BeginDate = beginDate;
            EndDate = endDate;
        }
        /// <summary>
        /// 开始日期。格式为 yyyymmdd
        /// </summary>
        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束日期，限定查询1天数据，允许设置的最大值为昨日。格式为 yyyymmdd
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}