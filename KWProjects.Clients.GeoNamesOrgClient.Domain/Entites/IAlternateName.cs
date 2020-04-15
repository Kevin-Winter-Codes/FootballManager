using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Clients.GeoNamesOrgClient.Domain.Entities
{
    public interface IAlternateName
    {
        string Language { get; set; }

        string Name { get; set; }

        /// <summary>
        /// Gets/sets wether this <see cref="AlternateName"/> is an official/preferred name.
        /// </summary>
        bool IsPreferredName { get; set; }

        /// <summary>
        /// Gets/sets wether this <see cref="AlternateName"/> is a short name like 'California' for 'State of California'.
        /// </summary>
        bool IsShortName { get; set; }

        /// <summary>
        /// Gets/sets wether this <see cref="AlternateName"/> is a colloquial or slang term.
        /// </summary>
        bool IsColloquial { get; set; }

        /// <summary>
        /// Gets/sets wether this <see cref="AlternateName"/> is historic and was used in the past
        /// </summary>
        bool IsHistoric { get; set; }
    }
}
