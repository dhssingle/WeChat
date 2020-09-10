using System.Threading.Tasks;

namespace WeChat.MiniProgram.AnalysisApi
{
    public interface IAnalysis
    {
        Task<GetRetainResponse> GetDailyRetain(GetDailyRetainRequest request);
        Task<GetRetainResponse> GetWeeklyRetain(GetWeeklyRetainRequest request);
        Task<GetRetainResponse> GetMonthlyRetain(GetMonthlyRetainRequest request);
        Task<GetDailySummaryResponse> GetDailySummary(GetDailySummaryRequest request);
        Task<GetDailyVisitTrendResponse> GetDailyVisitTrend(GetDailyVisitTrendRequest request);
        Task<GetWeeklyVisitTrendResponse> GetWeeklyVisitTrend(GetWeeklyVisitTrendRequest request);
        Task<GetMonthlyVisitTrendResponse> GetMonthlyVisitTrend(GetMonthlyVisitTrendRequest request);
        Task<GetUserPortraitResponse> GetUserPortrait(GetUserPortraitRequeset request);
        
    }
}