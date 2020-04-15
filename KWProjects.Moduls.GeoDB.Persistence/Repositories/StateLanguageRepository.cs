using KWProjects.Infrastructure.Data.Repository;
using KWProjects.Infrastructure.Data.Repository.EFCore;
using KWProjects.Moduls.GeoDB.Domain.Entities;
using KWProjects.Moduls.GeoDB.Domain.Repositories;
//using KWProjects.Moduls.GeoDB.Domain.Entities;
using KWProjects.Moduls.GeoDB.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KWProjects.Moduls.GeoDB.Persistence.Repositories
{
    public class StateLanguageRepository : RepositoryBase<StateLanguage, Guid>, IStateLanguageRepository
    {
        public StateLanguageRepository()
            : base(DbContextFactory.GeoDBContextInstance)
        {
        }

        public override void Commit()
        {
            base.Commit();
        }

        public override int Count()
        {
            return base.Count();
        }

        public override int Count(Expression<Func<StateLanguage, bool>> predicate)
        {
            return base.Count(predicate);
        }

        public override void Delete(Expression<Func<StateLanguage, bool>> predicate)
        {
            base.Delete(predicate);
        }

        public override void Delete(StateLanguage entity)
        {
            base.Delete(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override IList<StateLanguage> GetAll()
        {
            return base.GetAll();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Insert(StateLanguage entity)
        {
            base.Insert(entity);
        }

        public override StateLanguage Single(Expression<Func<StateLanguage, bool>> predicate)
        {
            return base.Single(predicate);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Update(StateLanguage orginalEntity, StateLanguage modifiedEntity)
        {
            base.Update(orginalEntity, modifiedEntity);
        }

        public override IQueryable<StateLanguage> Where(Expression<Func<StateLanguage, bool>> predicate)
        {
            return base.Where(predicate);
        }
    }
}
