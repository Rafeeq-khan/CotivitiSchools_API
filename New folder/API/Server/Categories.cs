using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Server
{
    public partial class Categories
    {
        public Categories()
        {
            Skills = new HashSet<Skills>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Skills> Skills { get; set; }
    }
}
