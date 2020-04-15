using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Clients.GeoNamesOrgClient.Domain.Entities
{
    public interface IGeoLocation
    {
        /// <summary>
        /// Gets the latitude of the location.
        /// </summary>
        decimal Latitude { get; set; }

        /// <summary>
        /// Sets the latitude of the location.
        /// </summary>
        decimal Longitude { get; set; }
    }
}
