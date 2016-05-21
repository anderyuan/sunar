using System.Linq;
using Esp.Auth.EntityFramework;
using Esp.Auth.MultiTenancy;

namespace Esp.Auth.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AuthDbContext _context;

        public DefaultTenantCreator(AuthDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == "Default");
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = "Default", Name = "Default"});
                _context.SaveChanges();
            }
        }
    }
}