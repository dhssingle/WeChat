using System.Net.Http;

namespace WeChat.MiniProgram.Models.Analysis
{
    /// <summary>
    /// 获取用户访问小程序日留存请求参数
    /// </summary>
    public class GetDailyRetainRequest : AnalysisRequest
    {
        GetDailyRetainRequest()
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
    }
}