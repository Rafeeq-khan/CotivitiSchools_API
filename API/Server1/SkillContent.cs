using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Server
{
    public partial class SkillContent
    {
        public int SkillId { get; set; }
        public int SkillContentId { get; set; }
        public string SkillContents { get; set; }
        public string ImagesLink { get; set; }
        public string VideosLink { get; set; }
        public int? Sequence { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
