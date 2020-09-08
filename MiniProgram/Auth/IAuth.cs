using System.Threading.Tasks;

namespace WeChat.MiniProgram
{
    public interface IAuth
    {
        Task<Code2SessionResponse> Code2Session(Code2SessionRequest request);
        Task<GetPaidUnionIdResponse> GetPaidUnionId(GetPaidUnionIdRequest request);
    }
}