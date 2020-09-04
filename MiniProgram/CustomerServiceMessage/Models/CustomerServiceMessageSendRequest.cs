using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace WeChat.MiniProgram
{
    public class CustomerServiceMessageSendRequest : CommonRequest
    {
        public CustomerServiceMessageSendRequest()
        {
            httpMethod = HttpMethod.Post;
            requestUri = "cgi-bin/message/custom/send?";
        }
        public CustomerServiceMessageSendRequest(string toUser, MsgType msgType, Text text = null, Image image = null, Link link = null, MiniProgramPage miniProgramPage = null) : this()
        {
            ToUser = toUser;
            MsgType = msgType;
            Text = text;
            Image = image;
            Link = link;
            MiniProgramPage = miniProgramPage;
        }
        /// <summary>
        /// 用户的 OpenID
        /// </summary>
        [JsonProperty("touser")]
        public string ToUser { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonProperty("msgtype")]
        public MsgType MsgType { get; set; }
        /// <summary>
        /// 文本消息，msgtype="text" 时必填
        /// </summary>
        [JsonProperty("text")]
        public Text Text { get; set; }
        /// <summary>
        /// 图片消息，msgtype="image" 时必填
        /// </summary>
        [JsonProperty("iamge")]
        public Image Image { get; set; }
        /// <summary>
        /// 图文链接，msgtype="link" 时必填
        /// </summary>
        [JsonProperty("link")]
        public Link Link { get; set; }
        /// <summary>
        /// 小程序卡片，msgtype="miniprogrampage" 时必填
        /// </summary>
        [JsonProperty("miniprogrampage")]
        public MiniProgramPage MiniProgramPage { get; set; }
    }
    public class Text
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }
    public class Image
    {
        /// <summary>
        /// 发送的图片的媒体ID，通过 <see href="https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/customer-message/customerServiceMessage.uploadTempMedia.html">新增素材接口</see> 上传图片文件获得。
        /// </summary>
        /// <value></value>
        [JsonProperty("media_id")]
        public string MediaId { get; set; }
    }
    public class Link
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 图文链接消息
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// 图文链接消息被点击后跳转的链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        /// <summary>
        /// 图文链接消息的图片链接，支持 JPG、PNG 格式，较好的效果为大图 640 X 320，小图 80 X 80
        /// </summary>
        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }
    }
    public class MiniProgramPage
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 小程序的页面路径，跟app.json对齐，支持参数，比如pages/index/index?foo=bar
        /// </summary>
        [JsonProperty("pagepath")]
        public string PagePath { get; set; }
        /// <summary>
        /// 小程序消息卡片的封面， image 类型的 media_id，通过 <see href="https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/customer-message/customerServiceMessage.uploadTempMedia.html">新增素材接口</see> 上传图片文件获得，建议大小为 520*416
        /// </summary>
        [JsonProperty("thumb_media_id")]
        public string ThumbMediaId { get; set; }
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MsgType
    {
        text,
        image,
        link,
        miniprogrampage
    }
}