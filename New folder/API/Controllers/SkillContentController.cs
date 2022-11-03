using API.Repository.SkillContentRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/skills/content")]
    [ApiController]
    [AllowAnonymous]
    public class SkillContentController : ControllerBase
    {
        private readonly ISkillContentRepo _skillcontent;

        public SkillContentController(ISkillContentRepo skillContent)
        {
            _skillcontent = skillContent;
        }
        [HttpGet]
        [Route("{skillId}")]
        public async Task<IActionResult> GetContentbyskillId([FromRoute] int skillId)
        {
            var content = await _skillcontent.GetSkillContent(skillId);
            return Ok(content);
        }
    }
}
