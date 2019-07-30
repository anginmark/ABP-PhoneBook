using Abp.MultiTenancy;
using LZRY.PACS.Authorization.Users;

namespace LZRY.PACS.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
