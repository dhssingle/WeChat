using System.Threading.Tasks;

namespace WeChat.MiniProgram
{
    public class CustomerServiceMessage
    {
        private readonly MiniProgramClient _client;

        public CustomerServiceMessage(MiniProgramClient client)
        {
            _client = client;
        }
        /// <summary>
        /// 获取客服消息内的临时素材。即下载临时的多媒体文件。目前小程序仅支持下载图片文件。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetTempMediaResponse> GetTempMedia(GetTempMediaRequest request)
        {
            return await _client.SendAsync<GetTempMediaResponse>(request);
        }
        /// <summary>
        /// 发送客服消息给用户。详细规则见 <see href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/customer-message/send.html">发送客服消息</see>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CustomerServiceMessageSendResponse> Send(CustomerServiceMessageSendRequest request)
        {
            return await _client.SendAsync<CustomerServiceMessageSendResponse>(request);
        }
    }
}