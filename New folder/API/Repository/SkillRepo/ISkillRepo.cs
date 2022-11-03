
using API.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.SkillRepo
{
    public interface ISkillRepo
    {
        public Task<List<Skills>> GetSkillsbyCatDB(int CatId);
        public Task<List<Skills>> GetSkillsbyskillIdDB(int skillId);
    }
}
