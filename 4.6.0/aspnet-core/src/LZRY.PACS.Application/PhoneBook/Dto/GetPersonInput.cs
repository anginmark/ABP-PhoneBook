using Abp.Runtime.Validation;
using LZRY.PACS.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LZRY.PACS.PhoneBook.Dto
{
    /// <summary>
    /// 获取到前台的联系人，在这一层就可以验证，规范化输入,分页和排序
    /// </summary>
    public class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
    {

        //规范化输入
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

        //模糊查询的过滤条件
        public string FilterText { get; set; }
    }
}
