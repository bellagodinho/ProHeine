using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Accounts;

namespace WeDancin.Domain.Interfaces.Accounts
{
    public interface IUserBankAccountRepository
    {
        Task<IEnumerable<UserBankAccount>> GetAsync(Guid id);
        Task<UserBankAccount> GetAsync(int id);

        Task<UserBankAccount> CreateAsync(UserBankAccount userBankAccount);
        Task<UserBankAccount> UpdateAsync(UserBankAccount userBankAccount);
    }
}
