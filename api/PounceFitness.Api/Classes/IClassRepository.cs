using System.Collections.Generic;
using System.Threading.Tasks;

namespace PounceFitness.Api.Classes
{
    public interface IClassRepository
    {
        Task<IEnumerable<Class>> GetAllAsync();
    }
}