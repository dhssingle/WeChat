using System.Threading.Tasks;
using WeChat.MiniProgram.Models.Analysis;

namespace WeChat.MiniProgram.Services
{
    public class AnalysisService
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

        /// <summary>
        /// 获取小程序新增或活跃用户的画像分布数据。时间范围支持昨天、最近7天、最近30天。
        /// 其中，新增用户数为时间范围内首次访问小程序的去重用户数，活跃用户数为时间范围内访问过小程序的去重用户数。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetUserPortraitResponse> GetUserPortrait(GetUserPortraitRequeset request)
        {
            return await _client.SendAsync<GetUserPortraitResponse>(request);
        }
        /// <summary>
        /// 获取用户小程序访问分布数据
        /// </summary>
        /// <param name="request"></param>0
        /// <returns></returns>
        public async Task<GetVisitDistributionResponse> GetVisitDistribution(GetVisitDistributionRequest request)
        {
            return await _client.SendAsync<GetVisitDistributionResponse>(request);
        }
        /// <summary>
        /// 访问页面。目前只提供按 page_visit_pv 排序的 top200。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetVisitPageResponse> GetVisitPage(GetVisitPageRequest request)
        {
            return await _client.SendAsync<GetVisitPageResponse>(request);
        }
    }
}