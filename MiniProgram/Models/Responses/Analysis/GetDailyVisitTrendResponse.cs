using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.Responses.Analysis
{
    public class GetDailyVisitTrendResponse : CommonResponse
    {
        [JsonProperty("list")]
        public GetDailyVisitTrendResponseResult[] List { get; set; }
    }
    public class GetDailyVisitTrendResponseResult
    {
        /// <summary>
        /// 日期，格式为 yyyymmdd
        /// </summary>
        [JsonProperty("ref_date")]
        public string RefDate { get; set; }
        /// <summary>
        /// 打开次数
        /// </summary>
        [JsonProperty("session_cnt")]
        public int SessionCnt { get; set; }
        /// <summary>
        /// 访问次数
        /// </summary>       
        [JsonProperty("visit_pv")]
        public int VisitPv { get; set; }
        /// <summary>
        /// 访问人数
        /// </summary>
        [JsonProperty("visit_uv")]
        public int VisitUv { get; set; }
        /// <summary>
        /// 新用户数
        /// </summary>
        [JsonProperty("visit_uv_new")]
        public int VisitUvNew { get; set; }
        /// <summary>
        /// 人均停留时长 (浮点型，单位：秒)
        /// </summary>
        [JsonProperty("stay_time_uv")]
        public double StayTimeUv { get; set; }
        /// <summary>
        /// 次均停留时长 (浮点型，单位：秒)
        /// </summary>
        [JsonProperty("stay_time_session")]
        public double StayTimeSession { get; set; }
        /// <summary>
        /// 平均访问深度 (浮点型)
        /// </summary>
        [JsonProperty("visit_depth")]
        public double VisitDepth { get; set; }
    }
}