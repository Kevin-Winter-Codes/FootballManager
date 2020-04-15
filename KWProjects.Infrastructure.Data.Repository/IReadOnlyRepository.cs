using KWProjects.Infrastructure.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KWProjects.Infrastructure.Data.Repository
{
    public interface IReadOnlyRepository<TEntity, TKey> where TEntity : class
    {
        // SINGLE
        TEntity Single(Expression<Func<TEntity, bool>> predicate);

        // WHERE
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        // ALL
        IList<TEntity> GetAll();
    }
}
