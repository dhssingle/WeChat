using System.Threading.Tasks;

namespace WeChat.MiniProgram
{
    public class Analysis
    {
        private readonly MiniProgramClient _client;
        public Analysis(MiniProgramClient client)
        {
            _client = client;
        }
        #region 访问留存
        /// <summary>
        /// 获取用户访问小程序日留存
        /// </summary>
        /// <param name="request"><see cref="GetDailyRetainRequest"></param>
        /// <returns></returns>
        public async Task<GetRetainResponse> GetDailyRetain(GetDailyRetainRequest request)
        {
            return await _client.SendAsync<GetRetainResponse>(request);
        }
        /// <summary>
        /// 获取用户访问小程序周留存
        /// </summary>
        /// <param name="request"><see cref="GetDailyRetainRequest"></param>
        /// <returns></returns>
        public async Task<GetRetainResponse> GetWeeklyRetain(GetWeeklyRetainRequest request)
        {
            return await _client.SendAsync<GetRetainResponse>(request);
        }
        /// <summary>
        /// 获取用户访问小程序月留存
        /// </summary>
        /// <param name="request"><see cref="GetDailyRetainRequest"></param>
        /// <returns></returns>
        public async Task<GetRetainResponse> GetMonthlyRetain(GetMonthlyRetainRequest request)
        {
            return await _client.SendAsync<GetRetainResponse>(request);
        }
        #endregion
        
    }
}