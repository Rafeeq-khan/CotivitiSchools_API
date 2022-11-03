using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Update
    {
        public string SkillId { get; set; }
        public string SkillContentId { get; set; }
        public string SkillContents { get; set; }
        public string ImagesLink { get; set; }
        public string VideosLink { get; set; }
        public string ModifiedBy { get; set; }
    }
}