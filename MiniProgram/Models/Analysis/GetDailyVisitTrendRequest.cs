namespace WeChat.MiniProgram.Models.Analysis
{
    public class GetDailyVisitTrendRequest : AnalysisRequest
    {
        GetDailyVisitTrendRequest()
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "datacube/getweanalysisappiddailyvisittrend?";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beginDate">开始日期。格式为 yyyymmdd</param>
        /// <param name="endDate">结束日期，限定查询1天数据，允许设置的最大值为昨日。格式为 yyyymmdd</param>
        public GetDailyVisitTrendRequest(string beginDate, string endDate)
        {
            BeginDate = beginDate;
            EndDate = endDate;
        }
    }
}