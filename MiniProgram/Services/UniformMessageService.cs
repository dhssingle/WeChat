using System.Threading.Tasks;
using WeChat.MiniProgram.Models.UniformMessage;
using WeChat.MiniProgram.Models.UniformMessage;

namespace WeChat.MiniProgram.Services
{
    public class UniformMessageService
    {
        private readonly MiniProgramClient _client;

        public UniformMessageService(MiniProgramClient client)
        {
            _client = client;
        }
        /// <summary>
        /// 下发小程序和公众号统一的服务消息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UniformSendResponse> UniformSend(UniformSendRequest request)
        {
            return await _client.SendAsync<UniformSendResponse>(request);
        }
    }
}