using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace HighClick.EntityFramework.Repositories
{
    public abstract class HighClickRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<HighClickDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected HighClickRepositoryBase(IDbContextProvider<HighClickDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class HighClickRepositoryBase<TEntity> : HighClickRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected HighClickRepositoryBase(IDbContextProvider<HighClickDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
