using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LZRY.PACS.PhoneBook.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace LZRY.PACS.PhoneBook.Dto
{
    /// <summary>
    /// 获取病人列表,用于查询的，添加映射(automapfrom(typeof(xx)))
    /// </summary>
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto:FullAuditedEntityDto
    {
        public string Name { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
    }
}
