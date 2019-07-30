using Abp.AutoMapper;
using LZRY.PACS.Authentication.External;

namespace LZRY.PACS.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
