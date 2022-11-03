using API.Repository.CaetegoryRepo;
using API.Repository.SkillRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api")]
    [ApiController]
    [AllowAnonymous]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly ISkillRepo _skillRepo;

        public CategoriesController(ICategoryRepo categoryRepo, ISkillRepo skillRepo)
        {
            _categoryRepo = categoryRepo;
            _skillRepo = skillRepo;
        }

        [HttpGet]
        [Route("Categories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var allCat = await _categoryRepo.GetCategoriesDB();
            return Ok(allCat);
        }

        [HttpGet]
        [Route("Categories/{catid}/skills")]
        public async Task<IActionResult> GetSkillsbyCat([FromRoute] int catId)
        {
            var allSkillsbyCat = await _skillRepo.GetSkillsbyCatDB(catId);
            return Ok(allSkillsbyCat);
        }


        

        

    }
}
