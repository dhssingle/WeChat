using System.Net.Http;
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
        /// <summary>
        /// 获取用户访问小程序日留存
        /// </summary>
        /// <param name="request"><see cref="GetDailyRetainRequest"></param>
        /// <returns></returns>
        public async Task<GetDailyRetainResponse> GetDailyRetain(GetDailyRetainRequest request)
        {
            return await _client.SendAsync<GetDailyRetainResponse>(request);
        }
    }
}