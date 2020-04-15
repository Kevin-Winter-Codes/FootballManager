using KWProjects.Moduls.GeoDB.Domain.Entities;
using KWProjects.Moduls.GeoDB.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KWProjects.Moduls.GeoDB.Service
{
    public class CityService
    {
        private CityRepository cityRepository = new CityRepository();

        public CityService()
        {

        }

        public IList<City> GetAll()
        {
            return cityRepository.GetAll();
        }

        public IList<City> GetCitiesByState(Guid stateId)
        {
            return cityRepository.Where(n => n.StateId == stateId).ToList();
        }

        public IList<City> GetCitiesByCountry(Guid countryId)
        {
            return cityRepository.Where(n => n.CountryId == countryId).ToList();
        }

        public int Count
        {
            get
            {
                return cityRepository.Count();
            }
        }
    }
}
