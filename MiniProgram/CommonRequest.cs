using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WeChat.MiniProgram
{
    public class CommonRequest : IRequest
    {
        protected HttpMethod httpMethod;
        protected string uri;
        public HttpMethod GetHttpMethod() => httpMethod;
        public string GetRequestUri() => uri;

        public string SetAccessToken(string accessToken)
        {
            return uri += $"access_token={accessToken}";
        }

        public string ToJson() => JsonConvert.SerializeObject(this, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });
    }
}