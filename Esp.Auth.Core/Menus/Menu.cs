using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esp.Auth.Menus
{
    [Table(name: "Menus")]
    public class Menu : Entity<long>, IMustHaveTenant
    {
        public virtual int TenantId { get; set; }

        public virtual string MenuName { get; set; }

        public virtual string DisplayName { get; set; }

        public virtual string MenuUrl { get; set; }

        public virtual string MenuCss { get; set; }

        public virtual bool IsExpand { get; set; }

        public virtual Menu Parent { get; set; }

        public virtual IList<Menu> Items { get; set; }

    }
}
