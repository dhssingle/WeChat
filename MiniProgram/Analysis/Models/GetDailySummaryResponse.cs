namespace WeChat.MiniProgram
{
    using Newtonsoft.Json;
    /// <summary>
    /// 获取用户访问小程序数据概况返回值
    /// </summary>
    public class GetDailySummaryResponse : CommonResponse
    {
        [JsonProperty("list")]
        public List[] List { get; set; }
    }
    public partial class List
    {
        [JsonProperty("ref_date")]
        public string RefDate { get; set; }

        [JsonProperty("visit_total")]
        public long VisitTotal { get; set; }

        [JsonProperty("share_pv")]
        public long SharePv { get; set; }

        [JsonProperty("share_uv")]
        public long ShareUv { get; set; }
    }
}