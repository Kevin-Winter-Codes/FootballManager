using KWProjects.Moduls.GeoDB.Domain.Entities;
using KWProjects.Moduls.GeoDB.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KWProjects.Moduls.GeoDB.Service
{
    public class StateService
    {
        StateRepository stateRepository = new StateRepository();

        public StateService()
        {

        }

        public IList<State> GetAll()
        {
            return stateRepository.GetAll();
        }

        public IList<State> GetStatesByCountry(Guid countryId)
        {
            return stateRepository.Where(n => n.CountryId == countryId).ToList();
        }

        public int Count
        {
            get
            {
                return stateRepository.Count();
            }
        }
    }
}
