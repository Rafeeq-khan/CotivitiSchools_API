using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Server
{
    public partial class Skills
    {
        public Skills()
        {
            SkillContent = new HashSet<SkillContent>();
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int CategoryId { get; set; }
        public int? ParentSkillId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<SkillContent> SkillContent { get; set; }
    }
}
