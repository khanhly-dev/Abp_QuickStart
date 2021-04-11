using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuickStart.Authorization;

namespace QuickStart
{
    [DependsOn(
        typeof(QuickStartCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class QuickStartApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<QuickStartAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(QuickStartApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
