using Newtonsoft.Json;

namespace WeChat.MiniProgram.Analysis
{
    /// <summary>
    /// 访问留存返回值
    /// </summary>
    public class GetRetainResponse : CommonResponse
    {
        /// <summary>
        /// 日期
        /// 日存留如："20170313"；
        /// 周存留如："20170306-20170312"；
        /// 月存留如："201702"。
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
        /// 标识
        /// 日留存：0开始，0表示当天，1表示1天后，依此类推，key取值分别是：0,1,2,3,4,5,6,7,14,30；
        /// 周留存：0开始，0表示当周，1表示1周后，依此类推，key取值分别是：0,1,2,3,4；
        /// 月留存：标识，0开始，0表示当月，1表示1月后，key取值分别是：0,1。
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