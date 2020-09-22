using System.Net.Http;
namespace WeChat.MiniProgram.Models.CustomerServiceMessage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    public class SetTypingRequest : CommonRequest
    {
        public SetTypingRequest(string toUser, SetTypingCommand command)
        {
            httpMethod = HttpMethod.Post;
            requestUri = "cgi-bin/message/custom/typing?";

            ToUser = toUser;
            Command = command;
        }
        /// <summary>
        /// 用户的 OpenID
        /// </summary>
        [JsonProperty("touser")]
        public string ToUser { get; }
        /// <summary>
        /// 命令
        /// </summary>
        [JsonProperty("command")]
        public SetTypingCommand Command { get; set; }

    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SetTypingCommand
    {
        /// <summary>
        /// 对用户下发"正在输入"状态
        /// </summary>
        Typing,
        /// <summary>
        /// 取消对用户的"正在输入"状态
        /// </summary>
        CancelTyping
    }
}