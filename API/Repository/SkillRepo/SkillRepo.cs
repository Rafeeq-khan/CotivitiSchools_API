
using API.Server;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.SkillRepo
{
    public class SkillRepo: ISkillRepo
    {
        private readonly rapidContext _varContext;

        public SkillRepo(rapidContext varContext)
        {
            _varContext = varContext;
        }

        public async Task<List<Skills>> GetSkillsbyCatDB(int catId)
        {
            var SkillsList = await _varContext.Skills.ToListAsync();
            var resSKills = new List<Skills>();
            foreach (var skill in SkillsList)
            {
                if (skill.CategoryId == catId && skill.ParentSkillId == null)
                {
                    resSKills.Add(skill);
                }
            }
            return resSKills;
        }

        public  Task<List<Skills>> GetSkillsbyskillIdDB(int skillId)
        {

            var result = _varContext.Skills.Where(id => id.ParentSkillId == skillId).ToListAsync();



            return result;


            /*var result2 = _context.Skills.Select(skilldet => new Skills()
            {
                SkillId = skilldet.SkillId,
                SkillName = skilldet.SkillName,
                CreatedDate = skilldet.CreatedDate
            }).Where(id => id.SkillId == skillId).ToListAsync();*/

            /*return result2;*/

            // return _context.Skills.Where(id => id.SkillId == skillId);
        }

    }
}
