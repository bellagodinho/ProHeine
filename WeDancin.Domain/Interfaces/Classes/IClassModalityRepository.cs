using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Classes;

namespace WeDancin.Domain.Interfaces.Classes
{
    public interface IClassModalityRepository
    {
        Task<IEnumerable<ClassModality>> GetAsync();
    }
}
