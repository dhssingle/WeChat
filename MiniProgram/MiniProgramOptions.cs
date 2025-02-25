namespace WeChat.MiniProgram
{
    public class MiniProgramOptions
    {
        /// <summary>
        /// 小程序唯一凭证，即 AppID，可在「微信公众平台 - 设置 - 开发设置」页中获得。（需要已经成为开发者，且帐号没有异常状态）
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 小程序唯一凭证密钥，即 AppSecret，获取方式同 appid
        /// </summary>
        public string AppSecret { get; set; }
    }
}