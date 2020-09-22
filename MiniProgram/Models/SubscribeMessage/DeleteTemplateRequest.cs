using System.Net.Http;
using Newtonsoft.Json;

namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class DeleteTemplateRequest : CommonRequest
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="priTmplId">要删除的模板id</param>
        public DeleteTemplateRequest(string priTmplId)
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "wxaapi/newtmpl/deltemplate";

            PriTmplId = priTmplId;
        }

        /// <summary>
        /// 要删除的模板id
        /// </summary>
        /// <value></value>
        [JsonProperty("priTmplId")]
        public string PriTmplId { get; }
    }
}