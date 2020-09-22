using System;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.WxACode
{
    public class CreateQRCodeRequest : CommonRequest
    {
        public CreateQRCodeRequest(string path, int width = 430)
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "cgi-bin/wxaapp/createwxaqrcode";

            Path = path;
            Width = width;
        }
        /// <summary>
        /// 扫码进入的小程序页面路径，最大长度 128 字节，不能为空；
        /// 对于小游戏，可以只传入 query 部分，来实现传参效果，
        /// 如：传入 "?foo=bar"，即可在 wx.getLaunchOptionsSync 接口中的 query 参数获取到 {foo:"bar"}。
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; }
        /// <summary>
        /// 二维码的宽度，单位 px。最小 280px，最大 1280px。默认值 430 px。
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; }
    }
}
