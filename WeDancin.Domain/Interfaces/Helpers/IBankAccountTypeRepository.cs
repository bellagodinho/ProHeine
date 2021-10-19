using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Helpers;

namespace WeDancin.Domain.Interfaces.Helpers
{
    public interface IBankAccountTypeRepository
    {
        Task<IEnumerable<BankAccountType>> GetAsync();
    }
}
