using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuickStart.Configuration;

namespace QuickStart.Web.Host.Startup
{
    [DependsOn(
       typeof(QuickStartWebCoreModule))]
    public class QuickStartWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public QuickStartWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuickStartWebHostModule).GetAssembly());
        }
    }
}
