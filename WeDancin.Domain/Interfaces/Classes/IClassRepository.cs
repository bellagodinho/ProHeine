using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Classes;

namespace WeDancin.Domain.Interfaces.Classes
{
    public interface IClassRepository
    {
        Task<IEnumerable<Class>> GetAsync();
        Task<Class> GetAsync(Guid id);

        Task<IEnumerable<Class>> GetClassesByLevelAsync(int id);
        Task<IEnumerable<Class>> GetClassesByTypeAsync(int id);
        Task<IEnumerable<Class>> GetClassesByModalityAsync(int id);

        Task<Class> CreateAsync(Class model);
        Task<Class> UpdateAsync(Class model);
    }
}
