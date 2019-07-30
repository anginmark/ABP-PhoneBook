using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LZRY.PACS.PhoneBook.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonEditDto
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
