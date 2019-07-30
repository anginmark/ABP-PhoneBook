using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LZRY.PACS.Authorization.Users;

namespace LZRY.PACS.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
