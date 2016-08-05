using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liuhl.AbpDemo.Authorization.Roles;
using Liuhl.AbpDemo.MultiTenancy;

namespace Liuhl.AbpDemo.Mapping
{
    public class TenantMap : EntityTypeConfiguration<Tenant>
    {
        public TenantMap()
        {
            ToTable("Tenants");
        }
    }
}
