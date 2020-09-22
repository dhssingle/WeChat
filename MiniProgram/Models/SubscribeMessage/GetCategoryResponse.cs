using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class GetCategoryResponse : CommonResponse
    {
        /// <summary>
        /// 类目列表
        /// </summary>
        /// <value></value>
        public IEnumerable<GetCategoryData> Data { get; set; }
    }

    public class GetCategoryData
    {
        /// <summary>
        /// 类目id，查询公共库模版时需要
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// 类目的中文名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}