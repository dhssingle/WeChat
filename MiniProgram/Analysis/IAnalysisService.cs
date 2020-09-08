using System.Threading.Tasks;

namespace WeChat.MiniProgram.Analysis
{
    public interface IAnalysisService
    {
        Task<GetRetainResponse> GetDailyRetain(GetDailyRetainRequest request);
        Task<GetDailySummaryResponse> GetDailySummary(GetDailySummaryRequest request);
        Task<GetDailyVisitTrendResponse> GetDailyVisitTrend(GetDailyVisitTrendRequest request);
        Task<GetRetainResponse> GetMonthlyRetain(GetMonthlyRetainRequest request);
        Task<GetRetainResponse> GetWeeklyRetain(GetWeeklyRetainRequest request);
        Task<GetWeeklyVisitTrendResponse> GetWeeklyVisitTrend(GetWeeklyRetainRequest request);
    }
}