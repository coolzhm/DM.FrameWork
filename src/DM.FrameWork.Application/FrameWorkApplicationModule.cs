using DM.FrameWork.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace DM.FrameWork
{
    [DependsOn(
        typeof(FrameWorkDomainModule),
        typeof(AbpIdentityApplicationModule))]
    public class FrameWorkApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<FrameWorkPermissionDefinitionProvider>();
            });

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<FrameWorkApplicationAutoMapperProfile>();
            });
        }
    }
}
