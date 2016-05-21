using Abp.Authorization;
using Esp.Auth.Authorization.Roles;
using Esp.Auth.MultiTenancy;
using Esp.Auth.Users;

namespace Esp.Auth.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
