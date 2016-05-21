using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Esp.Auth.EntityFramework.Repositories
{
    public abstract class AuthRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AuthDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AuthRepositoryBase(IDbContextProvider<AuthDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AuthRepositoryBase<TEntity> : AuthRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AuthRepositoryBase(IDbContextProvider<AuthDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
