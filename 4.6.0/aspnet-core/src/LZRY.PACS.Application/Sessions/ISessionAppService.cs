using System.Threading.Tasks;
using Abp.Application.Services;
using LZRY.PACS.Sessions.Dto;

namespace LZRY.PACS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
