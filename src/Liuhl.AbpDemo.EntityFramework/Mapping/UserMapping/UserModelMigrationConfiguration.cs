using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liuhl.AbpDemo.Mapping
{
    public static class UserModelMigrationConfiguration
    {
        public static void UserModuleMigrationMapping(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new TenantMap());
            modelBuilder.Configurations.Add(new UserLoginMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserRoleMap());

        }
    }
}
