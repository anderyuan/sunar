using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Esp.Auth.Web.Controllers
{
    //[AbpMvcAuthorize]
    public class HomeController : AuthControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}