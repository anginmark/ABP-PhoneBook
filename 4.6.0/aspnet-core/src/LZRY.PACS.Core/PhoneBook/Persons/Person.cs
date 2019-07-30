using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LZRY.PACS.PhoneBook.Persons
{
    /// <summary>
    /// 联系人信息，需要的属性从模板中集成，所有的属性在FullAutitedEntity
    /// </summary>
    public class Person:FullAuditedEntity
    {
        //对属性做校验
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        //邮箱格式校验
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
