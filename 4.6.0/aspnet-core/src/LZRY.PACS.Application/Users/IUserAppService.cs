using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LZRY.PACS.Roles.Dto;
using LZRY.PACS.Users.Dto;

namespace LZRY.PACS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
