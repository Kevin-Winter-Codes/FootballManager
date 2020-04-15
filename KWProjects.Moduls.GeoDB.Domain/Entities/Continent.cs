using KWProjects.Infrastructure.Domain.Entities;
using System;
using System.Collections.Generic;

namespace KWProjects.Moduls.GeoDB.Domain.Entities
{
    public partial class Continent 
    {
        public Continent()
        {
            Country = new HashSet<Country>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public int GeoNameOrgId { get; set; }

        public virtual ICollection<Country> Country { get; set; }
    }
}
