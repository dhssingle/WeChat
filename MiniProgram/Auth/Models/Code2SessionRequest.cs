using System.Net.Http;
using Newtonsoft.Json;

namespace WeChat.MiniProgram
{
    public class Code2SessionRequest : CommonRequest
    {
        public Code2SessionRequest()
        {
            httpMethod = HttpMethod.Get;
            requestUri = "sns/jscode2session?";
        }
        public Code2SessionRequest(string appId, string appSecret, string jsCode, string grantType) : this()
        {
            AppId = appId;
            AppSecret = appSecret;
            JsCode = jsCode;
            GrantType = grantType;
        }

        /// <summary>
        /// 小程序 appId
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; protected set; }

        /// <summary>
        /// 小程序 appSecret
        /// </summary>
        [JsonProperty("secret")]
        public string AppSecret { get; protected set; }

        /// <summary>
        /// 登录时获取的 code
        /// </summary>
        [JsonProperty("js_code")]
        public string JsCode { get; protected set; }

        /// <summary>
        /// 授权类型，此处只需填写 authorization_code
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }
    }
}