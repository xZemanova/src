using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace BurgerFanatics.EntityFramework.Repositories
{
    public abstract class BurgerFanaticsRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BurgerFanaticsDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BurgerFanaticsRepositoryBase(IDbContextProvider<BurgerFanaticsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BurgerFanaticsRepositoryBase<TEntity> : BurgerFanaticsRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BurgerFanaticsRepositoryBase(IDbContextProvider<BurgerFanaticsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
