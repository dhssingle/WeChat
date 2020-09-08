namespace WeChat.MiniProgram.Analysis
{
    /// <summary>
    /// 获取用户访问小程序数据概况请求参数
    /// </summary>
    public class GetDailySummaryRequest : AnalysisRequest
    {
        GetDailySummaryRequest()
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "datacube/getweanalysisappiddailysummarytrend?";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beginDate">开始日期。格式为 yyyymmdd</param>
        /// <param name="endDate">结束日期，限定查询1天数据，允许设置的最大值为昨日。格式为 yyyymmdd</param>
        public GetDailySummaryRequest(string beginDate, string endDate) : this()
        {
            BeginDate = beginDate;
            EndDate = endDate;
        }
    }
}