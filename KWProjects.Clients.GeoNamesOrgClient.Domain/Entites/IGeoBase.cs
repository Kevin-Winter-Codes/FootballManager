using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Clients.GeoNamesOrgClient.Domain.Entities
{
    public interface IGeoBase : IGeoLocation
    {
        //string ToponymName { get; set; }

        string Name { get; set; }

        int GeonameId { get; set; }

        string CountryCode { get; set; }

        string CountryName { get; set; }

        string Fcl { get; set; }

        string FclName { get; set; }

        string FCode { get; set; }

        string FCodeName { get; set; }

        long Population { get; set; }

        string AsciiName { get; set; }

        string AdminCode1 { get; set; }

        string AdminCode2 { get; set; }

        string AdminName1 { get; set; }

        string AdminName2 { get; set; }

        string ContinentCode { get; set; }

        GeoTyp CheckGeoname();
    }
}
