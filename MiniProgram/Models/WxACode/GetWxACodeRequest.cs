using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.WxACode
{
    public class GetWxACodeRequest : CommonRequest
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="path">扫码进入的小程序页面路径，最大长度 128 字节，不能为空；对于小游戏，可以只传入 query 部分，来实现传参效果，如：传入 "?foo=bar"，即可在 wx.getLaunchOptionsSync 接口中的 query 参数获取到 {foo:"bar"}。</param>
        /// <param name="width">二维码的宽度，单位 px。最小 280px，最大 1280px</param>
        /// <param name="Color">自动配置线条颜色，如果颜色依然是黑色，则说明不建议配置主色调</param>
        /// <param name="lineColor">auto_color 为 false 时生效，使用 rgb 设置颜色 例如 {"r":"xxx","g":"xxx","b":"xxx"} 十进制表示</param>
        /// <param name="isHyaline">是否需要透明底色，为 true 时，生成透明底色的小程序码</param>
        public GetWxACodeRequest(string path, int width = 430, bool autoColor = false, Dictionary<string, int> lineColor = null, bool isHyaline = false)
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "wxa/getwxacode";

            Path = path;
            Width = width;
            AutoColor = autoColor;
            LineColor = lineColor;
            IsHyaline = isHyaline;
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
        /// <summary>
        /// 自动配置线条颜色，如果颜色依然是黑色，则说明不建议配置主色调
        /// </summary>
        [JsonProperty("auto_color")]
        public bool AutoColor { get; }
        /// <summary>
        /// auto_color 为 false 时生效，使用 rgb 设置颜色 例如 {"r":"xxx","g":"xxx","b":"xxx"} 十进制表示
        /// </summary>
        [JsonProperty("line_color")]
        public Dictionary<string, int> LineColor { get; }
        /// <summary>
        /// 是否需要透明底色，为 true 时，生成透明底色的小程序码
        /// </summary>
        [JsonProperty("is_hyaline")]
        public bool IsHyaline { get; }

    }
}