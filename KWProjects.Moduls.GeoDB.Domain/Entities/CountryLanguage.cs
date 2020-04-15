using System;
using System.Collections.Generic;

namespace KWProjects.Moduls.GeoDB.Domain.Entities
{
    public partial class CountryLanguage
    {
        public Guid Id { get; set; }
        public Guid? LanguageId { get; set; }
        public Guid? CountryId { get; set; }
        public double? Percent { get; set; }

        public virtual Country Country { get; set; }
        public virtual Language Language { get; set; }
    }
}
