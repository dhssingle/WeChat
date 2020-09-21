namespace WeChat.MiniProgram.Models.Responses.Analysis
{
    using Newtonsoft.Json;
    /// <summary>
    /// 获取用户访问小程序数据概况返回值
    /// </summary>
    public class GetDailySummaryResponse : CommonResponse
    {
        [JsonProperty("list")]
        public GetDailySummaryResponseResult[] List { get; set; }
    }
    public partial class GetDailySummaryResponseResult
    {
        /// <summary>
        /// 日期，格式为 yyyymmdd
        /// </summary>
        [JsonProperty("ref_date")]
        public string RefDate { get; set; }
        /// <summary>
        /// 累计用户数
        /// </summary>
        [JsonProperty("visit_total")]
        public int VisitTotal { get; set; }
        /// <summary>
        /// 转发次数
        /// </summary>
        [JsonProperty("share_pv")]
        public int SharePv { get; set; }
        /// <summary>
        /// 转发人数
        /// </summary>
        [JsonProperty("share_uv")]
        public int ShareUv { get; set; }
    }
}