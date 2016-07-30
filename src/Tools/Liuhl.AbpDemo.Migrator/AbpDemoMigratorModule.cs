using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Liuhl.AbpDemo.EntityFramework;

namespace Liuhl.AbpDemo.Migrator
{
    [DependsOn(typeof(AbpDemoDataModule))]
    public class AbpDemoMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AbpDemoDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}