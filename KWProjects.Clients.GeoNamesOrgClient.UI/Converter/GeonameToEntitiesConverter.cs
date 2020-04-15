using KWProjects.Moduls.GeoDB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KWProjects.Clients.GeoNamesOrgClient.UI.Converter
{
    public static class GeonameToEntitiesConverter
    {
        public static Continent ToContinent(this DataGridViewRow row)
        {
            Continent continent = new Continent();
            continent.Id = Guid.NewGuid();
            continent.Name = row.Cells["Name"].Value.ToString();
            continent.GeoNameOrgId =  Convert.ToInt32(row.Cells["GeonameId"].Value.ToString());
            return continent;
        }
    }
}
