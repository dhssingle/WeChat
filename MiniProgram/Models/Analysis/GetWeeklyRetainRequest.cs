using System.Net.Http;

namespace WeChat.MiniProgram.Models.Analysis
{
    /// <summary>
    /// 获取用户访问小程序周留存请求参数
    /// </summary>
    public class GetWeeklyRetainRequest : AnalysisRequest
    {
        GetWeeklyRetainRequest()
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
    }
}