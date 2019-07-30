using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LZRY.PACS.PhoneBook.Dto;
using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;

namespace LZRY.PACS.PhoneBook
{
    public interface IPersonAppService:IApplicationService
    {
        //异步方式获取联系人列表
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        //根据一个条件检索出联系人信息
        Task<PersonListDto> GetPersonByIdAsync();

        //新增或者修改一个联系人信息
        Task CreateOrUpdatePersonAsync();

        //删除一个联系人信息,根据Id删除
        Task DeleltePersonAsync(EntityDto input);
    }
}
