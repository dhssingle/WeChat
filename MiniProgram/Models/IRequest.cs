using System.Net.Http;

namespace WeChat.MiniProgram.Models
{
    public interface IRequest
    {
        string ToJson();
        HttpMethod GetHttpMethod();
        string GetRequestUri();
        string SetAccessToken(string accessToken);
    }
}