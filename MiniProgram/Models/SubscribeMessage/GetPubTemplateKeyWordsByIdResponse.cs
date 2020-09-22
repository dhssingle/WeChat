using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class GetPubTemplateKeyWordsByIdResponse : CommonResponse
    {
        /// <summary>
        /// 模版标题列表总数
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        /// <summary>
        /// 关键词列表
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<GetPubTemplateKeyWordsByIdData> Data { get; set; }
    }

    public class GetPubTemplateKeyWordsByIdData
    {
        /// <summary>
        /// 关键词 id，选用模板时需要
        /// </summary>
        [JsonProperty("kid")]
        public long Kid { get; set; }
        /// <summary>
        /// 关键词内容
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 关键词内容对应的示例
        /// </summary>
        [JsonProperty("example")]
        public string Example { get; set; }
        /// <summary>
        /// 参数类型
        /// </summary>
        [JsonProperty("rule")]
        public string Rule { get; set; }
    }
}