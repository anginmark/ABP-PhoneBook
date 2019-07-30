using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LZRY.PACS.Dto
{
    /// <summary>
    /// 分页和排序输入dto
    /// </summary>
    public class PagedAndSortedInputDto : IPagedResultRequest, ISortedResultRequest
    {

        //跳到第几页
        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }
        //设置最大页数
        [Range(1,500)]
        public int MaxResultCount { get; set; }
        //排序

        public string Sorting { get; set; }
    }
}
