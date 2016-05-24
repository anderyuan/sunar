using System.Data.Common;
using Abp.Zero.EntityFramework;
using Esp.Auth.Authorization.Roles;
using Esp.Auth.MultiTenancy;
using Esp.Auth.Users;
using System.Data.Entity;
using Esp.Auth.Menus;

namespace Esp.Auth.EntityFramework
{
    public class AuthDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public IDbSet<Menu> Menus { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AuthDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AuthDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AuthDbContext since ABP automatically handles it.
         */
        public AuthDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AuthDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
