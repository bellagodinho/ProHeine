using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Accounts;
using WeDancin.Domain.Entities.Helpers.API;

namespace WeDancin.Domain.Interfaces.Accounts
{
    public interface IUserDetailsRepository
    {
        Task<APIResponse> GetAsync(Guid id);

        Task<APIResponse> CreateAsync(UserDetails userDetails);
        Task<APIResponse> UpdateAsync(UserDetails userDetails);

        UserDetails UserRepositoryUserDetailsMiddleware(object apiResponseResult);
    }
}
