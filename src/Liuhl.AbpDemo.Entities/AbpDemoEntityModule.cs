using System.Reflection;
using Abp.Modules;

namespace Liuhl.AbpDemo.Entity
{
    public class AbpDemoEntityModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
