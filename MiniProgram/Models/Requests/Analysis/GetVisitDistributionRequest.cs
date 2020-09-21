using System.Net.Http;

namespace WeChat.MiniProgram.Models.Requests.Analysis
{
    public class GetVisitDistributionRequest : AnalysisRequest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beginDate">开始日期。格式为 yyyymmdd</param>
        /// <param name="endDate">结束日期，限定查询 1 天数据，允许设置的最大值为昨日。格式为 yyyymmdd</param>
        public GetVisitDistributionRequest(string beginDate, string endDate)
        {
            BeginDate = beginDate;
            EndDate = endDate;
            httpMethod = HttpMethod.Post;
            requestUri = "datacube/getweanalysisappidvisitdistribution?";
        }
    }
}