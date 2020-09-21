using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.Responses.Analysis
{
    public class GetVisitPageResponse : CommonResponse
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
        public GetVisitPageResponseList[] List { get; set; }
    }

    public class GetVisitPageResponseList
    {
        /// <summary>
        /// 页面路径
        /// </summary>
        [JsonProperty("page_path")]
        public string PagePath { get; set; }
        /// <summary>
        /// 访问次数
        /// </summary>
        [JsonProperty("page_visit_pv")]
        public int PageVisitPv { get; set; }
        /// <summary>
        /// 访问人数
        /// </summary>
        [JsonProperty("page_visit_uv")]
        public int PageVisitUv { get; set; }
        /// <summary>
        /// 次均停留时长
        /// </summary>
        [JsonProperty("page_staytime_pv")]
        public double PageStaytimePv { get; set; }
        /// <summary>
        /// 进入页次数
        /// </summary>
        [JsonProperty("entrypage_pv")]
        public int EntrypagePv { get; set; }
        /// <summary>
        /// 退出页次数
        /// </summary>
        [JsonProperty("exitpage_pv")]
        public int ExitpagePv { get; set; }
        /// <summary>
        /// 转发次数
        /// </summary>
        [JsonProperty("page_share_pv")]
        public int PageSharePv { get; set; }
        /// <summary>
        /// 转发人数
        /// </summary>
        [JsonProperty("page_share_uv")]
        public int PageShareUv { get; set; }
    }
}

