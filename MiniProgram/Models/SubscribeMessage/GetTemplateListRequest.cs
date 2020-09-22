namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class GetTemplateListRequest : CommonRequest
    {
        public GetTemplateListRequest()
        {
            httpMethod = System.Net.Http.HttpMethod.Get;
            requestUri = "wxaapi/newtmpl/gettemplate";
        }
        
    }
}