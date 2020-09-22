namespace WeChat.MiniProgram.Models.Analysis
{
    using Newtonsoft.Json;

    /// <summary>
    /// 小程序新增或活跃用户的画像分布数据返回值
    /// </summary>
    public class GetUserPortraitResponse : CommonResponse
    {
        /// <summary>
        /// 时间范围，如："20170611-20170617"
        /// </summary>
        [JsonProperty("ref_date")]
        public string RefDate { get; set; }
        /// <summary>
        /// 新用户画像
        /// </summary>
        [JsonProperty("visit_uv_new")]
        public GetUserPortraitResponseVisitUv VisitUvNew { get; set; }
        /// <summary>
        /// 活跃用户画像
        /// </summary>
        [JsonProperty("visit_uv")]
        public GetUserPortraitResponseVisitUv VisitUv { get; set; }
    }

    /// <summary>
    /// 用户画像
    /// </summary>
    public class GetUserPortraitResponseVisitUv
    {
        /// <summary>
        /// 省份，如北京、广东等
        /// </summary>
        [JsonProperty("province")]
        public GetUserPortraitResponseCommonType[] Province { get; set; }
        /// <summary>
        /// 城市，如北京、广州等
        /// </summary>
        [JsonProperty("city")]
        public GetUserPortraitResponseCommonType[] City { get; set; }
        /// <summary>
        /// 性别，包括男、女、未知
        /// </summary>
        [JsonProperty("genders")]
        public GetUserPortraitResponseCommonType[] Genders { get; set; }
        /// <summary>
        /// 终端类型，包括 iPhone，android，其他
        /// </summary>
        [JsonProperty("platforms")]
        public GetUserPortraitResponseCommonType[] Platforms { get; set; }
        /// <summary>
        /// 机型，如苹果 iPhone 6，OPPO R9 等
        /// </summary>
        [JsonProperty("devices")]
        public GetUserPortraitResponseCommonType[] Devices { get; set; }
        /// <summary>
        /// 年龄，包括17岁以下、18-24岁等区间
        /// </summary>
        [JsonProperty("ages")]
        public GetUserPortraitResponseCommonType[] Ages { get; set; }
    }

    public class GetUserPortraitResponseCommonType
    {
        /// <summary>
        /// 属性值id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// 属性值名称，与id对应。如属性为 province 时，返回的属性值名称包括「广东」等。
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }


}
