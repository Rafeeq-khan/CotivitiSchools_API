using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class SkillUpdate
    {
        public string SkillId { get; set; }
        public string ModifiedBy { get; set; }
        public string SkillName { get; set; }
    }
}
