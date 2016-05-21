using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Esp.Auth.MultiTenancy.Dto;

namespace Esp.Auth.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
