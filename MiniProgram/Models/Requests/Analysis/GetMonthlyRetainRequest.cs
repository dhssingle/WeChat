using System.Net.Http;

namespace WeChat.MiniProgram.Models.Requests.Analysis
{
    /// <summary>
    /// 获取用户访问小程序月留存请求参数
    /// </summary>
    public class GetMonthlyRetainRequest : AnalysisRequest
    {
        GetMonthlyRetainRequest()
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
    }
}