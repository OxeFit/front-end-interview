using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PounceFitness.Api.Skills
{
    [ApiController]
    [Route("[controller]")]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillRepository _skillRepository;

        public SkillsController(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        [HttpGet]
        public Task<IEnumerable<Skill>> GetAllAsync() => _skillRepository.GetAllAsync();

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(Skill), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 404)]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var skill = await _skillRepository.GetByIdAsync(id);
            if (skill == null) return NotFound();
            return Ok(skill);
        }
    }
}