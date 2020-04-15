using KWProjects.Client.GeonameOrgClient;
using KWProjects.Clients.GeoNamesOrgClient.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Clients.GeoNamesOrgClient.Extentions
{
    public static class GeoNamesOrgExtentions
    {

        public static  IList<Geoname> Children(this Geoname geoname)
        {
            return GeoNamesOrgWebservice.Children(geoname, "ffmcoder");
        }


        public static IList<Geoname> Children(this Geoname geoname, string SelectedUsername = "ffmcoder")
        {
            return GeoNamesOrgWebservice.Children(geoname, SelectedUsername);
        }
    }
}
