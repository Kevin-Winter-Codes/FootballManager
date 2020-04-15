using KWProjects.Infrastructure.Data.Repository;
using KWProjects.Infrastructure.Data.Repository.EFCore;
using KWProjects.Moduls.GeoDB.Domain.Entities;
using KWProjects.Moduls.GeoDB.Domain.Repositories;
using KWProjects.Moduls.GeoDB.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KWProjects.Moduls.GeoDB.Persistence.Repositories
{
    public class CountryLanguageRepository : RepositoryBase<CountryLanguage, Guid>, ICountryLanguageRepository
    {
        public CountryLanguageRepository()
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

        public override int Count(Expression<Func<CountryLanguage, bool>> predicate)
        {
            return base.Count(predicate);
        }

        public override void Delete(Expression<Func<CountryLanguage, bool>> predicate)
        {
            base.Delete(predicate);
        }

        public override void Delete(CountryLanguage entity)
        {
            base.Delete(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override IList<CountryLanguage> GetAll()
        {
            return base.GetAll();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Insert(CountryLanguage entity)
        {
            base.Insert(entity);
        }

        public override CountryLanguage Single(Expression<Func<CountryLanguage, bool>> predicate)
        {
            return base.Single(predicate);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Update(CountryLanguage orginalEntity, CountryLanguage modifiedEntity)
        {
            base.Update(orginalEntity, modifiedEntity);
        }

        public override IQueryable<CountryLanguage> Where(Expression<Func<CountryLanguage, bool>> predicate)
        {
            return base.Where(predicate);
        }
    }
}
