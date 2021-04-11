using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace QuickStart.Authorization
{
    public class QuickStartAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            var dashBoard = context.CreatePermission(PermissionNames.Pages_DashBoard, L("DashBoard"));
            dashBoard.CreateChildPermission(PermissionNames.Pages_DashBoard_City, L("DashBoard-City"));
            dashBoard.CreateChildPermission(PermissionNames.Pages_DashBoard_District, L("DashBoard-District"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, QuickStartConsts.LocalizationSourceName);
        }
    }
}
