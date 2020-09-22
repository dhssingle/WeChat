using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class GetPubTemplateTitleListResponse : CommonResponse
    {
        /// <summary>
        /// 模版标题列表总数
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        /// <summary>
        /// 模板标题列表
        /// </summary>
        /// <value></value>
        [JsonProperty("data")]
        public IEnumerable<GetPubTemplateTitleListData> Data { get; set; }
    }

    public class GetPubTemplateTitleListData
    {
        [JsonProperty("TId")]
        public int TId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
    }
}