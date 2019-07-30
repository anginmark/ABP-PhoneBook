using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LZRY.PACS.PhoneBook.Dto;
using LZRY.PACS.PhoneBook.Persons;
using Microsoft.EntityFrameworkCore;
//使用linq
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using Abp.AutoMapper;

namespace LZRY.PACS.PhoneBook
{
    public class PersonAppService : PACSAppServiceBase, IPersonAppService
    {
        //使用依赖注入
        private readonly IRepository<Person> _personRepostory;

        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepostory = personRepository;
        }


        public Task CreateOrUpdatePersonAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleltePersonAsync(EntityDto input)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _personRepostory.GetAll();
            var personcount = await query.CountAsync();
            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            //获取person列表属性后转后为PersonlistDto,使用automapper
            var dtos = persons.MapTo<List<PersonListDto>>();

            //传递有联系人条数，和dtos
            return new PagedResultDto<PersonListDto>(personcount,dtos);

        }

        public Task<PersonListDto> GetPersonByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
