//using KWProjects.Moduls.GeoDB.Persistence.Repositories;
using KWProjects.Moduls.GeoDB.Domain.Entities;
using KWProjects.Moduls.GeoDB.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KWProjects.Moduls.GeoDB.Service
{
    public class ContinentService
    {
        ContinentRepository continentRepository = new ContinentRepository();

        public IList<Continent> GetAll()
        {
            return continentRepository.GetAll();
        }

        public void AddRange(IList<Continent> continents)
        {
            foreach (Continent item in continents)
            {
                continentRepository.Insert(item);
            }
            continentRepository.Commit();
        }

        public int Count
        {
            get
            {
                return continentRepository.Count();
            }
        }
    }
}
