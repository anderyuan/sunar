using Abp.AutoMapper;
using Esp.Auth.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esp.Auth.Menus.Dto
{
    [AutoMapFrom(typeof(Menu))]
    public class MenuListDto
    {
        public int TenantId { get; set; }

        public string MenuName { get; set; }

        public string DisplayName { get; set; }

        public string MenuUrl { get; set; }

        public string MenuCss { get; set; }

        public bool IsExpand { get; set; }
    }
}
