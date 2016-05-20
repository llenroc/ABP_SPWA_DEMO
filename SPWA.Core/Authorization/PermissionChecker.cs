using Abp.Authorization;
using SPWA.Authorization.Roles;
using SPWA.MultiTenancy;
using SPWA.Users;

namespace SPWA.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
