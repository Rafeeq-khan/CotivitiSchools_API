using API.Server;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.SkillContentRepo
{
    public class SkillContentRepo: ISkillContentRepo
    {
        private readonly rapidContext _context;

        public SkillContentRepo(rapidContext context)
        {
            _context = context;
        }
        public async Task<List<SkillContent>> GetSkillContent(int skillID) 
        {
            var contentList =await _context.SkillContent.Where(id => id.SkillId == skillID ).ToListAsync();

            return contentList;
            //var resultList = new List<SkillContent>();
        }
        /*public async Task<List<SkillContent>> GetSkillContent(int skillID)
        {
            var contentList = await _context.SkillContent.Where(id => id.SkillId == skillID).ToListAsync();

            return contentList;
            //var resultList = new List<SkillContent>();
        }*/
    }
}
