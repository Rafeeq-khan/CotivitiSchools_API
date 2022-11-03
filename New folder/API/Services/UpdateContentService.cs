using API.Models;
using API.Repository.SkillContentRepo;
using API.Server;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace API.Services
{
    public class UpdateContentService: IUpdateContentService
    {
        private readonly rapidContext _context;
        private readonly IConfiguration _config;

        public UpdateContentService(rapidContext context, IConfiguration config) 
        {
            _context = context;
            _config = config;
        }

        public async  Task<string> UpdateContents(int id, Update contents)
        {
            var entity = await _context.SkillContent.FindAsync(id);
            if(entity != null)
            {
                entity.SkillContents = contents.SkillContents;
                entity.ModifiedBy = contents.ModifiedBy;
                entity.ModifiedDt = DateTime.Now;
            }

            var res = await _context.SaveChangesAsync();
            if(res>0)
            {
              return "Success";
            } else
            return "Failed";
            
        }
    }
}/*
if (entity != null)
{
    
}
var op = (context.Entry(entity).State = EntityState.Modified).ToString();
var status = context.SaveChanges();
if (status != 0)
{
    return "Success";
}
            else
                return "Failed";*/


/*var entity = await context.SkillContent.FirstAsync(skill => skill.SkillId == skillId);
             if(entity != null)
            {
                entity.SkillContents = content;
                entity.ModifiedDt = DateTime.Now;
                context.Entry(entity).State = EntityState.Modified;
            }
             try
            {
                if (context.SaveChanges() != 0)
                {
                     return "Success";
                }
                else
                {
                    return "context failed";
                }
                
            }
            catch (DbUpdateConcurrencyException)
            {
                return "failed to Update";
            }*/