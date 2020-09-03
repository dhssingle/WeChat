using System.Net.Http;

namespace WeChat.MiniProgram
{
    public interface IRequest
    {
        string ToJson();
        HttpMethod GetHttpMethod();
        string GetRequestUri();
        string SetAccessToken(string accessToken);
    }
}