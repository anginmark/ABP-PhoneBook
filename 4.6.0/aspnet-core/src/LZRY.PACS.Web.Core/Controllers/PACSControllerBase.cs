using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LZRY.PACS.Controllers
{
    public abstract class PACSControllerBase: AbpController
    {
        protected PACSControllerBase()
        {
            LocalizationSourceName = PACSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
