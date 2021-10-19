using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Accounts;

namespace WeDancin.Domain.Interfaces.Accounts
{
    public interface IUserTypeRepository
    {
        Task<IEnumerable<UserType>> GetAsync();
        Task<UserType> GetAsync(int id);
    }
}
