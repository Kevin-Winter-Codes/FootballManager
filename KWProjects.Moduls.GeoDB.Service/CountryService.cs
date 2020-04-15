using KWProjects.Moduls.GeoDB.Domain.Entities;
using KWProjects.Moduls.GeoDB.Persistence.Repositories;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Moduls.GeoDB.Service
{
    public class CountryService
    {
        CountryRepository countryRepository = new CountryRepository();

        public IList<Country> GetAll()
        {
            return countryRepository.GetAll();
        }

        public IList<Country> GetCountriesByContinent(Guid continentId)
        {
            return countryRepository.Where(n => n.ContinentId == continentId).ToList();
        }

        public int Count
        {
            get
            {
                return countryRepository.Count();
            }
        }
    }
}
