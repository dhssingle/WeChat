using System.Net.Http;
using Newtonsoft.Json;

namespace WeChat.MiniProgram
{
    public class GetWeeklyRetainRequest : CommonRequest
    {
        public GetWeeklyRetainRequest()
        {
            httpMethod = HttpMethod.Post;
            requestUri = "datacube/getweanalysisappidweeklyretaininfo?";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beginDate">开始日期，为周一日期。格式为 yyyymmdd</param>
        /// <param name="endDate">结束日期，为周日日期，限定查询一周数据。格式为 yyyymmdd</param>
        /// <returns></returns>
        public GetWeeklyRetainRequest(string beginDate, string endDate):this()
        {
            BeginDate = beginDate;
            EndDate = endDate;
        }
        /// <summary>
        /// 开始日期，为周一日期。格式为 yyyymmdd
        /// </summary>
        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束日期，为周日日期，限定查询一周数据。格式为 yyyymmdd
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}