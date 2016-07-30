﻿using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Liuhl.AbpDemo.EntityFramework;

namespace Liuhl.AbpDemo
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AbpDemoCoreModule))]
    public class AbpDemoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AbpDemoDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
