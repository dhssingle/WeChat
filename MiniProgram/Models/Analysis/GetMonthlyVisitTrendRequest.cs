namespace WeChat.MiniProgram.Models.Analysis
{
    public class GetMonthlyVisitTrendRequest : AnalysisRequest
    {
        GetMonthlyVisitTrendRequest()
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "datacube/getweanalysisappidmonthlyvisittrend?";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beginDate">开始日期，为自然月第一天。格式为 yyyymmdd</param>
        /// <param name="endDate">结束日期，为自然月最后一天，限定查询一个月的数据。格式为 yyyymmdd</param>
        public GetMonthlyVisitTrendRequest(string beginDate, string endDate)
        {
            BeginDate = beginDate;
            EndDate = endDate;
        }
    }
}