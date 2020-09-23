using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.UpdatableMessage
{
    public class CreateActivityIdRequest : CommonRequest
    {
        public CreateActivityIdRequest(string unionId)
        {
            httpMethod = System.Net.Http.HttpMethod.Get;
            requestUri = "cgi-bin/message/wxopen/activityid/create";

            UnionId = unionId;
        }

        /// <summary>
        /// 为私密消息创建activity_id时，指定分享者为unionid用户。其余用户不能用此activity_id分享私密消息。私密消息暂不支持云函数生成activity id。
        /// </summary>
        /// <value></value>
        [JsonProperty("unionid")]
        public string UnionId { get; }
    }
}