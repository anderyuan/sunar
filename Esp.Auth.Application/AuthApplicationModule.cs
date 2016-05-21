using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Esp.Auth
{
    [DependsOn(typeof(AuthCoreModule), typeof(AbpAutoMapperModule))]
    public class AuthApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
