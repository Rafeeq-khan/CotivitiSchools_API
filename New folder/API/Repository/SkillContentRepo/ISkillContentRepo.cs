using API.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.SkillContentRepo
{
    public interface ISkillContentRepo
    {
        public Task<List<SkillContent>> GetSkillContent(int skillID);
    }
}
