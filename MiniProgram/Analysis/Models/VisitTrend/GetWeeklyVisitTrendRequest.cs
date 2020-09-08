namespace WeChat.MiniProgram.Analysis
{
    public class GetWeeklyVisitTrendRequest : AnalysisRequest
    {
        GetWeeklyVisitTrendRequest()
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "datacube/getweanalysisappidweeklyvisittrend?";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beginDate">开始日期，为周一日期。格式为 yyyymmdd</param>
        /// <param name="endDate">结束日期，为周日日期，限定查询一周数据。格式为 yyyymmdd</param>
        public GetWeeklyVisitTrendRequest(string beginDate, string endDate)
        {
            BeginDate = beginDate;
            EndDate = endDate;
        }
    }
}