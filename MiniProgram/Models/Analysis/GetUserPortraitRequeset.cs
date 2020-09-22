namespace WeChat.MiniProgram.Models.Analysis
{
    public class GetUserPortraitRequeset : AnalysisRequest
    {
        GetUserPortraitRequeset()
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "datacube/getweanalysisappiduserportrait?";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beginDate">开始日期。格式为 yyyymmdd</param>
        /// <param name="endDate">结束日期，开始日期与结束日期相差的天数限定为0/6/29，分别表示查询最近1/7/30天数据，允许设置的最大值为昨日。格式为 yyyymmdd</param>
        public GetUserPortraitRequeset(string beginDate, string endDate)
        {
            BeginDate = beginDate;
            EndDate = endDate;
        }
    }
}