﻿using Newtonsoft.Json;

namespace WeChat.MiniProgram.Analysis
{
    public class GetMonthlyVisitTrendResponse : CommonResponse
    {
        [JsonProperty("list")]
        public GetMonthlyVisitTrendResponseResult[] List { get; set; }
    }
    public class GetMonthlyVisitTrendResponseResult
    {
        /// <summary>
        /// 时间，格式为 yyyymm，如："201702"
        /// </summary>
        [JsonProperty("ref_date")]
        public string RefDate { get; set; }
        /// <summary>
        /// 打开次数（自然月内汇总）
        /// </summary>
        [JsonProperty("session_cnt")]
        public long SessionCnt { get; set; }
        /// <summary>
        /// 访问次数（自然月内汇总）
        /// </summary>       
        [JsonProperty("visit_pv")]
        public long VisitPv { get; set; }
        /// <summary>
        /// 访问人数（自然月内去重）
        /// </summary>
        [JsonProperty("visit_uv")]
        public long VisitUv { get; set; }
        /// <summary>
        /// 新用户数（自然月内去重）
        /// </summary>
        [JsonProperty("visit_uv_new")]
        public long VisitUvNew { get; set; }
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