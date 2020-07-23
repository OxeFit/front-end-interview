using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PounceFitness.Api.Classes
{
    [ApiController]
    [Route("[controller]")]
    public class ClassesController : ControllerBase
    {
        private readonly IClassRepository _classRepository;

        public ClassesController(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        [HttpGet]
        public Task<IEnumerable<Class>> GetAllAsync()
        {
            return _classRepository.GetAllAsync();
        }
    }
}