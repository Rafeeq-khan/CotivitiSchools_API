using API.Repository.SkillContentRepo;
using API.Repository.SkillRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/skills")]
    [ApiController]
    [AllowAnonymous]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillRepo _skillRepo;
        private readonly ISkillContentRepo _contentRepo;

        public SkillsController(ISkillRepo skillRepo, ISkillContentRepo contentRepo)
        {
            _skillRepo = skillRepo;
            _contentRepo = contentRepo;
        }

        [HttpGet]
        [Route("{skillId}")]
        public async Task<IActionResult> GetSkillsbyskillId([FromRoute] int skillId)
        {
            var SkillsbyskillId = await _skillRepo.GetSkillsbyskillIdDB(skillId);
            return Ok(SkillsbyskillId);
        }

/*        [HttpGet]
        [Route("{sId}")]
        public async Task<IActionResult> GetSkillContentbySkillId([FromRoute] int sId)
        {
            var content = await _contentRepo.GetSkillContent(sId);
            return Ok(content);
        }*/

    }
}
