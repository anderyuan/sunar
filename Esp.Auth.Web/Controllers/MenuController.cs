using Esp.Auth.Munus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Esp.Auth.Web.Controllers
{
    public class MenuController : AuthControllerBase
    {
        private readonly IMenuAppService _menuAppService;

        public MenuController(IMenuAppService menuAppService)
        {
            this._menuAppService = menuAppService;
        }

        // GET: Menu
        public async Task<ActionResult> Index()
        {
            var output = await _menuAppService.GetMenus();
            return View(output);
        }
    }
}