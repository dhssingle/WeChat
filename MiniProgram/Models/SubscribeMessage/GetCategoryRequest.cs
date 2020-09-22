namespace WeChat.MiniProgram.Models.SubscribeMessage
{
    public class GetCategoryRequest : CommonRequest
    {
        public GetCategoryRequest()
        {
            httpMethod = System.Net.Http.HttpMethod.Get;
            requestUri = "wxaapi/newtmpl/getcategory";
        }
    }
}