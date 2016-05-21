using System.Web.Mvc;

namespace Esp.Auth.Web.Controllers
{
    public class AboutController : AuthControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}