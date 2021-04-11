using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace QuickStart.Controllers
{
    public abstract class QuickStartControllerBase: AbpController
    {
        protected QuickStartControllerBase()
        {
            LocalizationSourceName = QuickStartConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
