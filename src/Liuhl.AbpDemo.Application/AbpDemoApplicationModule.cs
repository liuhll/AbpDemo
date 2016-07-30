using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Liuhl.AbpDemo
{
    [DependsOn(typeof(AbpDemoCoreModule), typeof(AbpAutoMapperModule))]
    public class AbpDemoApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
