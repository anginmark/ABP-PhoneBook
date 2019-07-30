using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LZRY.PACS.MultiTenancy.Dto;

namespace LZRY.PACS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

