using System;
using System.Collections.Generic;

namespace KWProjects.Moduls.GeoDB.Domain.Entities
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
            CountryLanguage = new HashSet<CountryLanguage>();
            State = new HashSet<State>();
            StateLanguage = new HashSet<StateLanguage>();
        }

        public Guid Id { get; set; }
        public Guid? ContinentId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int? Population { get; set; }
        public byte[] FlagImage { get; set; }

        public int GeoNameOrgId { get; set; }

        public virtual Continent Continent { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<CountryLanguage> CountryLanguage { get; set; }
        public virtual ICollection<State> State { get; set; }
        public virtual ICollection<StateLanguage> StateLanguage { get; set; }
    }
}
