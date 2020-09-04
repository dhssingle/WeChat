using System.Threading.Tasks;

namespace WeChat.MiniProgram
{
    public class Auth
    {
        private readonly MiniProgramClient _client;

        public Auth(MiniProgramClient client)
        {
            _client = client;
        }

        /// <summary>
        /// 登录凭证校验。
        /// 通过 <see href="https://developers.weixin.qq.com/miniprogram/dev/api/open-api/login/wx.login.html">wx.login</see> 接口获得临时登录凭证 code 后传到开发者服务器调用此接口完成登录流程。
        /// 更多使用方法详见 <see href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/login.html">小程序登录</see>。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Code2SessionResponse> Code2Session(Code2SessionRequest request)
        {
            return await _client.SendAsync<Code2SessionResponse>(request);
        }
        /// <summary>
        /// 用户支付完成后，获取该用户的 <see href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/union-id.html">UnionId</see>，无需用户授权。
        /// 注意：调用前需要用户完成支付，且在支付后的五分钟内有效。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetPaidUnionIdResponse> GetPaidUnionId(GetPaidUnionIdRequest request)
        {
            return await _client.SendAsync<GetPaidUnionIdResponse>(request);
        }
        
    }
}