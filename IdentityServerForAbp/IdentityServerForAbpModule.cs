using Abp.IdentityServer4;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestProject;

namespace IdentityServerForAbp
{
    [DependsOn(typeof(TestProjectWebCoreModule))]
    public class IdentityServerForAbpModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IdentityServerForAbpModule).GetAssembly());
        }
    }
}
