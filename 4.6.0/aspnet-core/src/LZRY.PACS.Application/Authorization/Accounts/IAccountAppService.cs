using System.Threading.Tasks;
using Abp.Application.Services;
using LZRY.PACS.Authorization.Accounts.Dto;

namespace LZRY.PACS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
