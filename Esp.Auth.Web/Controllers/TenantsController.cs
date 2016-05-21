using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Esp.Auth.Authorization;
using Esp.Auth.MultiTenancy;

namespace Esp.Auth.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : AuthControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}