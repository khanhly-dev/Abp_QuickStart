using Abp.Authorization;
using QuickStart.Authorization.Roles;
using QuickStart.Authorization.Users;

namespace QuickStart.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
