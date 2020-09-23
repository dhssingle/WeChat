using System.Threading.Tasks;
using WeChat.MiniProgram.Models.UpdatableMessage;

namespace WeChat.MiniProgram.Services
{
    public class UpdatableMessageService
    {
        private readonly MiniProgramClient _client;
        public UpdatableMessageService(MiniProgramClient client)
        {
            _client = client;
        }
        /// <summary>
        /// 创建被分享动态消息或私密消息的 activity_id。
        /// 详见<see href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/share/updatable-message.html">动态消息</see>。
        /// </summary>
        public async Task<CreateActivityIdResponse> CreateActivityId(CreateActivityIdRequest request)
        {
            return await _client.SendAsync<CreateActivityIdResponse>(request);
        }
        /// <summary>
        /// 修改被分享的动态消息。
        /// 详见<see href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/share/updatable-message.html">动态消息</see>。
        /// </summary>
        public async Task<SetUpdatableMsgResponse> SetUpdatableMsg(SetUpdatableMsgRequest request)
        {
            return await _client.SendAsync<SetUpdatableMsgResponse>(request);
        }
    }
}