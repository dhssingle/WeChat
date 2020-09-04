using Newtonsoft.Json;

namespace WeChat.MiniProgram
{
    public class GetDailyRetainResponse : CommonResponse
    {
        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("ref_date")]
        public string RefDate { get; set; }
        /// <summary>
        /// 新增用户留存
        /// </summary>

        [JsonProperty("visit_uv_new")]
        public VisitUv[] VisitUvNew { get; set; }
        /// <summary>
        /// 活跃用户留存
        /// </summary>

        [JsonProperty("visit_uv")]
        public VisitUv[] VisitUv { get; set; }
    }

    public class VisitUv
    {
        /// <summary>
        /// 标识，0开始，表示当天，1表示1天后。依此类推，key取值分别是：0,1,2,3,4,5,6,7,14,30
        /// </summary>
        [JsonProperty("key")]
        public long Key { get; set; }
        /// <summary>
        /// key对应日期的新增用户数/活跃用户数（key=0时）或留存用户数（k>0时）
        /// </summary>
        /// <value></value>
        [JsonProperty("value")]
        public long Value { get; set; }
    }
}