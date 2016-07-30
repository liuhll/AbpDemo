using Abp.Authorization;
using Liuhl.AbpDemo.Authorization.Roles;
using Liuhl.AbpDemo.MultiTenancy;
using Liuhl.AbpDemo.Users;

namespace Liuhl.AbpDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
