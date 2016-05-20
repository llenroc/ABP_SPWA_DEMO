using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace SPWA
{
    [DependsOn(typeof(SPWACoreModule), typeof(AbpAutoMapperModule))]
    public class SPWAApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
