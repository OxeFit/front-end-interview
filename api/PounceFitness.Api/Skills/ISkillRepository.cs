using System.Collections.Generic;
using System.Threading.Tasks;

namespace PounceFitness.Api.Skills
{
    public interface ISkillRepository
    {
        Task<IEnumerable<Skill>> GetAllAsync();

        Task<Skill> GetByIdAsync(string skillId);
    }
}