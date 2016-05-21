using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Esp.Auth.Authorization.Roles;
using Esp.Auth.Editions;
using Esp.Auth.Users;

namespace Esp.Auth.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}