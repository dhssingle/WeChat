using System.Threading.Tasks;
using WeChat.MiniProgram.Models.WxACode;

namespace WeChat.MiniProgram.Services
{
    public class WxACodeService
    {
        private readonly MiniProgramClient _client;

        public WxACodeService(MiniProgramClient client)
        {
            _client = client;
        }
        /// <summary>
        /// 获取小程序二维码，适用于需要的码数量较少的业务场景。通过该接口生成的小程序码，永久有效，有数量限制，详见<see href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/qr-code.html">获取二维码</see>。
        /// </summary>
        public async Task<CreateQRCodeResponse> CreateQRCode(CreateQRCodeRequest request)
        {
            return await _client.SendAsync<CreateQRCodeResponse>(request);
        }
        /// <summary>
        /// 获取小程序码，适用于需要的码数量较少的业务场景。通过该接口生成的小程序码，永久有效，有数量限制，详见<see href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/qr-code.html">获取二维码</see>。
        /// </summary>
        public async Task<GetWxACodeResponse> GetWxACode(GetWxACodeRequest request)
        {
            return await _client.SendAsync<GetWxACodeResponse>(request);
        }
        /// <summary>
        /// 获取小程序码，适用于需要的码数量极多的业务场景。通过该接口生成的小程序码，永久有效，数量暂无限制。 更多用法详见 <see href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/qr-code.html">获取二维码</see>。
        /// </summary>
        public async Task<GetWxACodeUnlimitResponse> GetUnlimited(GetWxACodeUnlimitRequest request)
        {
            return await _client.SendAsync<GetWxACodeUnlimitResponse>(request);
        }
    }
}
