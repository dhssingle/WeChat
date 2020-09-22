using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class GetPubTemplateTitleListRequest : CommonRequest
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ids">类目 id，多个用逗号隔开</param>
        /// <param name="start">用于分页，表示从 start 开始。从 0 开始计数。</param>
        /// <param name="limit">用于分页，表示拉取 limit 条记录。最大为 30。</param>
        public GetPubTemplateTitleListRequest(string ids, int start, int limit)
        {
            httpMethod = System.Net.Http.HttpMethod.Get;
            requestUri = "wxaapi/newtmpl/getpubtemplatetitles";

            Ids = ids;
            Start = start;
            Limit = limit;
        }
        /// <summary>
        /// 类目 id，多个用逗号隔开
        /// </summary>
        [JsonProperty("ids")]
        public string Ids { get; }
        /// <summary>
        /// 用于分页，表示从 start 开始。从 0 开始计数。
        /// </summary>
        [JsonProperty("start")]
        public int Start { get; }
        /// <summary>
        /// 用于分页，表示拉取 limit 条记录。最大为 30。
        /// </summary>
        [JsonProperty("limit")]
        public long Limit { get; }
    }
}