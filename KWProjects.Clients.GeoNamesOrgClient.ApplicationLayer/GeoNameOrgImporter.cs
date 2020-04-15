using KWProjects.Client.GeonameOrgClient;
using KWProjects.Clients.GeoNamesOrgClient.Domain.Entities;
using KWProjects.Clients.GeoNamesOrgClient.Extentions;
using KWProjects.Moduls.GeoDB.Domain.Entities;
using KWProjects.Moduls.GeoDB.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Clients.GeoNamesOrgClient.ApplicationLayer
{
    public class GeoNameOrgImporter
    {
        private int GeoRootID = 6295630;
        private string username = "ffmcoder";

        private ContinentService continentService;
        private CountryService countryService;
        private StateService stateService;
        private CityService cityService;

        public IList<Continent> Continents { get; set; }

        public IList<Country> Countries { get; set; }

        public IList<State> States { get; set; }

        public IList<City> Cities { get; set; }

        public IList<Geoname> GeonameResults { get; set; }

        public AvailableOperations AvailableOperations { get;set;}

        public GeoNameOrgImporter()
        {
            continentService = new ContinentService();
            countryService = new CountryService();
            stateService = new StateService();
            cityService = new CityService();
        }

        public void Init()
        {
            Continents = continentService.GetAll();
            ResultGeonameList(GeoRootID);
        }

        public void RefreshOperations()
        {
            //if (Continents.Count == 0)
            //{
            //    AvailableOperations = AvailableOperations.ImportContinents;
            //}
            //else if (Countries.Count == 0)
            //    AvailableOperations = AvailableOperations.ImportCountries;

            //else if (States.Count == 0)
            //    AvailableOperations = AvailableOperations.ImportCountries | AvailableOperations.ImportStates;

            //else if (Cities.Count == 0)
            //    AvailableOperations = AvailableOperations.ImportCountries | AvailableOperations.ImportStates | AvailableOperations.ImportCities;
        }

        public void LoadCountries(Guid ContinentId)
        {
            if (Continents.Count != 0)
                Countries = countryService.GetCountriesByContinent(ContinentId);


            RefreshOperations();
        }

        public void LoadStatesComboBox(Guid CountryId)
        {
            if (Countries.Count != 0)
                States = stateService.GetStatesByCountry(CountryId);

            RefreshOperations();
        }

        public void LoadCitiesComboBox(Guid StateId)
        {
            if (States.Count != 0)
                Cities = cityService.GetCitiesByState(StateId);

            RefreshOperations();
        }

        public void ResultGeonameList(int GeonameId)
        {
            GeonameResults = GeoNamesOrgWebservice.Children(GeonameId, username, GeoNamesDataStyle.Full);

            RefreshOperations();
        }




        public void InsertContinents(IList<Continent> continents)
        {
            continentService.AddRange(continents);
        }
    }

    [Flags]
    public enum AvailableOperations { ImportContinents=1, ImportCountries=2, ImportStates=4, ImportCities=8 }
}
