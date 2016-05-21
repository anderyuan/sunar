using System.Threading.Tasks;
using Abp.Application.Services;
using Esp.Auth.Roles.Dto;

namespace Esp.Auth.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
