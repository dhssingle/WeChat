using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WeChat.MiniProgram.Models.Responses.Analysis
{
    public class GetVisitDistributionResponse : CommonResponse
    {
        /// <summary>
        /// 日期，格式为 yyyymmdd
        /// </summary>
        [JsonProperty("ref_date")]
        public string RefDate { get; set; }
        /// <summary>
        /// 数据列表
        /// </summary>
        [JsonProperty("list")]
        public GetVisitDistributionResponseList[] List { get; set; }
    }

    public class GetVisitDistributionResponseList
    {
        /// <summary>
        /// 分布类型
        /// </summary>
        [JsonProperty("index")]
        public GetVisitDistributionResponseIdenx Index { get; set; }
        /// <summary>
        /// 分布数据列表
        /// </summary>>

        [JsonProperty("item_list")]
        public GetVisitDistributionResponseItem[] ItemList { get; set; }
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetVisitDistributionResponseIdenx
    {
        /// <summary>
        /// 访问来源分布
        /// </summary>
        access_source_session_cnt,
        /// <summary>
        /// 访问时长分布
        /// </summary>
        access_staytime_info,
        /// <summary>
        /// 访问深度的分布
        /// </summary>
        access_depth_info,
    }

    public class GetVisitDistributionResponseItem
    {
        /// <summary>
        /// 场景 id，定义在各个 index 下不同，具体参见下方表格
        /// </summary>
        [JsonProperty("key")]
        public int Key { get; set; }
        /// <summary>
        /// 该场景 id 访问 pv
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
