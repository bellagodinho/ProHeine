using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Helpers;

namespace WeDancin.Domain.Interfaces.Helpers
{
    public interface IBankRepository
    {
        Task<IEnumerable<Bank>> GetAsync();
    }
}
