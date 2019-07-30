using Abp.Application.Services.Dto;

namespace LZRY.PACS.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

