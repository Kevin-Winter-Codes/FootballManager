using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Moduls.GeonameOrg.Domain.Entities
{
    public partial class Geonames_Relations
    {
        public System.Guid Id { get; set; }
        public int ParentID { get; set; }
        public int ChildID { get; set; }
        public string Type { get; set; }
    }
}
