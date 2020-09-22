using System.Net.Http;
using System;
using System.Threading.Tasks;

using WeChat.MiniProgram.Models.CustomerServiceMessage;
using WeChat.MiniProgram.Models.CustomerServiceMessage;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.Services
{
    public class CustomerServiceMessageService
    {
        private readonly MiniProgramClient _client;

        public CustomerServiceMessageService(MiniProgramClient client)
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
        /// <summary>
        /// 下发客服当前输入状态给用户。详见 <see href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/customer-message/typing.html">客服消息输入状态</see>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SetTypingResponse> SetTyping(SetTypingRequest request)
        {
            return await _client.SendAsync<SetTypingResponse>(request);
        }
        /// <summary>
        /// 把媒体文件上传到微信服务器。目前仅支持图片。用于发送客服消息或被动回复用户消息。
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<UploadTempMediaResponse> UploadTempMedia(UploadTempMediaRequest request)
        {
            request.SetAccessToken(await _client.GetAccessToken());
            var requestMessage = new HttpRequestMessage(request.GetHttpMethod(), request.GetRequestUri() + "&type=" + request.Type)
            {
                Content = new MultipartFormDataContent
                {
                    { new StreamContent(request.Media), "imageFile", "image" }
                }
            };
            var response = await _client.Client.SendAsync(requestMessage);
            return JsonConvert.DeserializeObject<UploadTempMediaResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}