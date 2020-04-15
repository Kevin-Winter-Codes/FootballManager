using KWProjects.Infrastructure.Data.Repository.Traits;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KWProjects.Infrastructure.Data.Repository
{
    public interface IRepositoryBase<TEntity, TKey> :
        IReadOnlyRepository<TEntity, TKey>,
        ICanAdd<TEntity>,
        ICanModify<TEntity>,
        ICanDelete<TEntity> where TEntity : class
    {
        int Count();
        int Count( Expression<Func<TEntity, bool>> predicate );

        void Commit();
    }
}
