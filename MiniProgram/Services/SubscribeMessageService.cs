using System.Threading.Tasks;
using WeChat.MiniProgram.Models.SubscribeMessage;

namespace WeChat.MiniProgram.Services
{
    public class SubscribeMessageService
    {
        private readonly MiniProgramClient _client;

        public SubscribeMessageService(MiniProgramClient client)
        {
            _client = client;
        }
        /// <summary>
        /// 组合模板并添加至帐号下的个人模板库
        /// </summary>
        public async Task<AddTemplateResponse> AddTemplate(AddTemplateRequest request)
        {
            return await _client.SendAsync<AddTemplateResponse>(request);
        }
        /// <summary>
        /// 删除帐号下的个人模板
        /// </summary>
        public async Task<DeleteTemplateResponse> DeleteTemplate(DeleteTemplateRequest request)
        {
            return await _client.SendAsync<DeleteTemplateResponse>(request);
        }
        /// <summary>
        /// 获取小程序账号的类目
        /// </summary>
        public async Task<GetCategoryResponse> GetCategory(GetCategoryRequest request)
        {
            return await _client.SendAsync<GetCategoryResponse>(request);
        }
        /// <summary>
        /// 获取模板标题下的关键词列表
        /// </summary>
        public async Task<GetPubTemplateKeyWordsByIdResponse> GetPubTemplateKeyWordsById(GetPubTemplateKeyWordsByIdRequest request)
        {
            return await _client.SendAsync<GetPubTemplateKeyWordsByIdResponse>(request);
        }
        /// <summary>
        /// 获取帐号所属类目下的公共模板标题
        /// </summary>
        public async Task<GetPubTemplateTitleListResponse> GetPubTemplateTitleList(GetPubTemplateTitleListRequest request)
        {
            return await _client.SendAsync<GetPubTemplateTitleListResponse>(request);
        }
        /// <summary>
        /// 获取当前帐号下的个人模板列表
        /// </summary>
        public async Task<GetTemplateListResponse> GetTemplateList(GetTemplateListRequest request)
        {
            return await _client.SendAsync<GetTemplateListResponse>(request);
        }
        /// <summary>
        /// 发送订阅消息
        /// </summary>
        public async Task<SubscribeMessageSendResponse> Send(SubscribeMessageSendRequest request)
        {
            return await _client.SendAsync<SubscribeMessageSendResponse>(request);
        }
    }
}