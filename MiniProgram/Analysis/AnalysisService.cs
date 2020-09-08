using System.Threading.Tasks;

namespace WeChat.MiniProgram.Analysis
{
    public class AnalysisService : IAnalysisService
    {
        private readonly MiniProgramClient _client;
        public AnalysisService(MiniProgramClient client)
        {
            _client = client;
        }
        #region 访问留存
        /// <summary>
        /// 获取用户访问小程序日留存
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetRetainResponse> GetDailyRetain(GetDailyRetainRequest request)
        {
            return await _client.SendAsync<GetRetainResponse>(request);
        }
        /// <summary>
        /// 获取用户访问小程序周留存
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetRetainResponse> GetWeeklyRetain(GetWeeklyRetainRequest request)
        {
            return await _client.SendAsync<GetRetainResponse>(request);
        }
        /// <summary>
        /// 获取用户访问小程序月留存
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetRetainResponse> GetMonthlyRetain(GetMonthlyRetainRequest request)
        {
            return await _client.SendAsync<GetRetainResponse>(request);
        }
        #endregion

        /// <summary>
        /// 获取用户访问小程序数据概况
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetDailySummaryResponse> GetDailySummary(GetDailySummaryRequest request)
        {
            return await _client.SendAsync<GetDailySummaryResponse>(request);
        }
        
        #region 访问趋势
        /// <summary>
        /// 获取用户访问小程序数据日趋势
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetDailyVisitTrendResponse> GetDailyVisitTrend(GetDailyVisitTrendRequest request)
        {
            return await _client.SendAsync<GetDailyVisitTrendResponse>(request);
        }
        /// <summary>
        /// 获取用户访问小程序数据周趋势
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetWeeklyVisitTrendResponse> GetWeeklyVisitTrend(GetWeeklyVisitTrendRequest request)
        {
            return await _client.SendAsync<GetWeeklyVisitTrendResponse>(request);
        }
        /// <summary>
        /// 获取用户访问小程序数据月趋势(能查询到的最新数据为上一个自然月的数据)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetMonthlyVisitTrendResponse> GetMonthlyVisitTrend(GetMonthlyVisitTrendRequest request)
        {
            return await _client.SendAsync<GetMonthlyVisitTrendResponse>(request);
        }
        #endregion
    }
}