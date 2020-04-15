using System;
using System.Collections.Generic;

namespace KWProjects.Moduls.GeoDB.Domain.Entities
{
    public partial class Language
    {
        public Language()
        {
            CountryLanguage = new HashSet<CountryLanguage>();
            StateLanguage = new HashSet<StateLanguage>();
        }

        public Guid Id { get; set; }
        public string Language1 { get; set; }

        public virtual ICollection<CountryLanguage> CountryLanguage { get; set; }
        public virtual ICollection<StateLanguage> StateLanguage { get; set; }
    }
}
