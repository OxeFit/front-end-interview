using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PounceFitness.Api.Skills
{
    public class InMemorySkillRepository : ISkillRepository
    {
        private readonly IEnumerable<Skill> _skills;

        public InMemorySkillRepository(IEnumerable<Skill> skills)
        {
            _skills = skills?.ToList() ?? Enumerable.Empty<Skill>();
        }

        public Task<IEnumerable<Skill>> GetAllAsync() => Task.FromResult(_skills);

        public Task<Skill> GetByIdAsync(string skillId)
        {
            return Task.FromResult(_skills.FirstOrDefault(s => s.Id == skillId));
        }
    }
}