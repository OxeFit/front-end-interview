using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PounceFitness.Api.Classes
{
    public class InMemoryClassRepository : IClassRepository
    {
        private readonly IEnumerable<Class> _classes;

        public InMemoryClassRepository(IEnumerable<Class> classes)
        {
            _classes = classes?.ToList() ?? Enumerable.Empty<Class>();
        }
        
        public Task<IEnumerable<Class>> GetAllAsync() => Task.FromResult(_classes);
    }
}