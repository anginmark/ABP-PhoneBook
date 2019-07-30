using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LZRY.PACS.Configuration;

namespace LZRY.PACS.Web.Host.Startup
{
    [DependsOn(
       typeof(PACSWebCoreModule))]
    public class PACSWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PACSWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PACSWebHostModule).GetAssembly());
        }
    }
}
