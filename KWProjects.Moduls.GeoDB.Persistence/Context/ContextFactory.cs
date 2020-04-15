using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Moduls.GeoDB.Persistence.Context
{
    public static class DbContextFactory
    {
        private static GeoDBContext geoDBContext = null;

        static DbContextFactory()
        {
            var optionsBuilder = new DbContextOptionsBuilder<GeoDBContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=GeoDB;Integrated Security=true;");

            geoDBContext = new GeoDBContext(optionsBuilder.Options);
        }

        public static GeoDBContext GeoDBContextInstance
        {
            get { return geoDBContext; }
        }
    }
}
