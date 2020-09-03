using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Options;
using System.Linq;
using System;

namespace WeChat.MiniProgram
{
    public class MiniProgramClient
    {
        private readonly HttpClient _client;
        private readonly IDistributedCache _distributedCache;
        private readonly MiniProgramOptions _options;
        public MiniProgramClient(HttpClient client, IDistributedCache distributedCache, IOptions<MiniProgramOptions> optionsAccessor)
        {
            _client = client;
            _distributedCache = distributedCache;
            _options = optionsAccessor.Value;
        }
        public async Task<IResponse> SendAsync<IResponse>(IRequest request, bool needAccessToken = true)
        {
            if (needAccessToken)
                request.SetAccessToken(await GetAccessToken());
            var message = BuildRequestMessage(request);
            var responseMessage = await _client.SendAsync(message);
            return JsonConvert.DeserializeObject<IResponse>(await responseMessage.Content.ReadAsStringAsync());
        }
        private HttpRequestMessage BuildRequestMessage(IRequest request)
        {
            if (request.GetHttpMethod() == HttpMethod.Get)
            {
                return BuildGetRequestMessage(request);
            }
            else
            {
                return BuildPostRequestMessage(request);
            }
        }
        private HttpRequestMessage BuildPostRequestMessage(IRequest request)
        {
            return new HttpRequestMessage(request.GetHttpMethod(), request.GetRequestUri())
            {
                Content = new StringContent(request.ToJson(), Encoding.UTF8, "application/json")
            };
        }
        private HttpRequestMessage BuildGetRequestMessage(IRequest request)
        {
            var requestUri = request.GetRequestUri();
            var method = request.GetHttpMethod();

            if (request == null) return new HttpRequestMessage(method, requestUri.TrimEnd('?'));

            return new HttpRequestMessage(method, BuildQueryString(requestUri, request));
        }
        private string BuildQueryString(string requestUri, IRequest request)
        {
            if (request == null) return requestUri;
            var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(request.ToJson());
            requestUri += requestUri.Contains("access_token") ? "&" : "";
            var sb = new StringBuilder(requestUri);
            foreach (var item in dict)
            {
                sb.Append($"{item.Key}={item.Value}&");
            }
            return sb.ToString().TrimEnd('&');
        }
        private async Task<string> GetAccessToken()
        {
            var token = await _distributedCache.GetStringAsync("access_token");
            if (string.IsNullOrEmpty(token))
            {
                var result = await _client.GetStringAsync($"cgi-bin/token?grant_type=client_credential&appid={_options.AppId}&secret={_options.AppSecret}");
                if (!result.Contains("access_token"))
                    throw new Exception();
                token = result
                .Split(',')
                .FirstOrDefault(t => t.Contains("access_token"))
                .Split(':')
                .ElementAtOrDefault(1)
                .Trim('"');
                await _distributedCache.SetStringAsync("access_token", token, new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(7100)
                });
            }
            return token;
        }
    }
}