using System.Net.Http;
using Newtonsoft.Json;

namespace WeChat.MiniProgram
{
    public class GetMonthlyRetainRequest : CommonRequest
    {
        public GetMonthlyRetainRequest()
        {
            httpMethod = HttpMethod.Post;
            requestUri = "datacube/getweanalysisappidmonthlyretaininfo?";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beginDate">开始日期，为自然月第一天。格式为 yyyymmdd</param>
        /// <param name="endDate">结束日期，为自然月最后一天，限定查询一个月数据。格式为 yyyymmdd</param>
        /// <returns></returns>
        public GetMonthlyRetainRequest(string beginDate, string endDate):this()
        {
            BeginDate = beginDate;
            EndDate = endDate;
        }
        /// <summary>
        /// 开始日期，为自然月第一天。格式为 yyyymmdd
        /// </summary>
        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束日期，为自然月最后一天，限定查询一个月数据。格式为 yyyymmdd
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}