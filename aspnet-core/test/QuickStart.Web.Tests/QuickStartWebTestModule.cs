using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuickStart.EntityFrameworkCore;
using QuickStart.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace QuickStart.Web.Tests
{
    [DependsOn(
        typeof(QuickStartWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class QuickStartWebTestModule : AbpModule
    {
        public QuickStartWebTestModule(QuickStartEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuickStartWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(QuickStartWebMvcModule).Assembly);
        }
    }
}