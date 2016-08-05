using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liuhl.AbpDemo.Mapping
{
    public static class SettingModelMigrationConfiguration
    {
        public static void SettingModuleMigrationMapping(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LanguageMap());
            modelBuilder.Configurations.Add(new LanguageTextMap());
            modelBuilder.Configurations.Add(new SettingMap());
        }
    }
}
