using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Esp.Auth.EntityFramework;

namespace Esp.Auth.Migrator
{
    [DependsOn(typeof(AuthDataModule))]
    public class AuthMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AuthDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}