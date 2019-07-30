using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LZRY.PACS.PhoneBook.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace LZRY.PACS.PhoneBook.PhoneNumbers
{
    /// <summary>
    /// 继承ID,添加时间
    /// </summary>
    public class PhoneNumber : Entity<long>, IHasCreationTime
    {
        [Required]
        [MaxLength(11)]
        public string Number { get; set; }
        public DateTime CreationTime { get; set; }

        //建立关系,一对多的关系
        public int PersonId { get; set; }
        public Person Persons { get; set; }
    }
}
