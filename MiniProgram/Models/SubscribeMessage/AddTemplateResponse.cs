using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class AddTemplateResponse : CommonResponse
    {
        /// <summary>
        /// 添加至帐号下的模板id，发送小程序订阅消息时所需
        /// </summary>
        /// <value></value>
        [JsonProperty("priTmplId")]
        public string PriTmplId { get; set; }
    }
}