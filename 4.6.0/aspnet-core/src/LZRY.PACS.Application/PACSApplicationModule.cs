using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LZRY.PACS.Authorization;

namespace LZRY.PACS
{
    [DependsOn(
        typeof(PACSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PACSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PACSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PACSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
