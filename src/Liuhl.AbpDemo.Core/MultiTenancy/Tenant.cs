using Abp.MultiTenancy;
using Liuhl.AbpDemo.Users;

namespace Liuhl.AbpDemo.MultiTenancy
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