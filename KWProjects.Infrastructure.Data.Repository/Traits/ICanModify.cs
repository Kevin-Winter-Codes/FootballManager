using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Infrastructure.Data.Repository.Traits
{
    public interface ICanModify<TEntity> where TEntity : class
    {
        void Update(TEntity orginalEntity, TEntity modifiedEntity);
    }
}
