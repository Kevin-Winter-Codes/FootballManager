using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Moduls.GeonameOrg.Domain.Entities
{
    public partial class Geoname
    {
        public int GeoNameId { get; set; }
        public string Name { get; set; }
        public string AsciiName { get; set; }
        public string AlternateNames { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string Feature_Class { get; set; }
        public string Feature_Code { get; set; }
        public string Country_Code { get; set; }
        public string CC2 { get; set; }
        public string Admin1_Code { get; set; }
        public string Admin2_Code { get; set; }
        public string Admin3_Code { get; set; }
        public string Admin4_Code { get; set; }
        public Nullable<long> Population { get; set; }
        public Nullable<int> Elevation { get; set; }
        public Nullable<int> DEM { get; set; }
        public string Timezone { get; set; }
        public Nullable<System.DateTime> Modification_Date { get; set; }


    }
}
