using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Infrastructure.Data.Repository.Traits
{
    public interface ICanAdd<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
    }
}
