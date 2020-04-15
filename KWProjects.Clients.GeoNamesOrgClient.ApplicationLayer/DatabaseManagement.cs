using KWProjects.Moduls.GeoDB.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Clients.GeoNamesOrgClient.ApplicationLayer
{
    public static class GeoDBManagement
    {
        public static bool IsDatabaseEmpty()
        {
            ContinentService continentService = new ContinentService();
            CountryService countryService = new CountryService();
            StateService stateService = new StateService();
            CityService cityService = new CityService();


            if (continentService.Count != 0)
                return false;

            if (countryService.Count != 0)
                return false;

            if (stateService.Count != 0)
                return false;

            if (cityService.Count != 0)
                return false;

            return true;
        }

        
    }
}
