using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SPWA.EntityFramework.Repositories
{
    public abstract class SPWARepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SPWADbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SPWARepositoryBase(IDbContextProvider<SPWADbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SPWARepositoryBase<TEntity> : SPWARepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SPWARepositoryBase(IDbContextProvider<SPWADbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
