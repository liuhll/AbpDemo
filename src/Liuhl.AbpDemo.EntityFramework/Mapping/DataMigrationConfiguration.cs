using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liuhl.AbpDemo.Mapping
{
    public static class DataMigrationConfiguration
    {
        public static void ConfigurationTablesMapping(DbModelBuilder modelBuilder)
        {
            SettingModelMigrationConfiguration.SettingModuleMigrationMapping(modelBuilder);
            UserModelMigrationConfiguration.UserModuleMigrationMapping(modelBuilder);
        }
    }
}
