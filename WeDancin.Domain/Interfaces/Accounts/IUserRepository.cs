using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Accounts;
using WeDancin.Domain.Entities.Helpers.API;

namespace WeDancin.Domain.Interfaces.Accounts
{
    public interface IUserRepository
    {
        Task<APIResponse> GetAsync(Guid id);

        Task<APIResponse> CreateAsync(User user);
        Task<APIResponse> UpdateAsync(User user);

        Task<APIResponse> LoginAsync(UserLogin login);
        bool UserLoginExists(string email);

        Task<bool> UsernameExists(string username);

        Task<bool> ConfirmMailAsync(Guid id);

        Task<Guid> PasswordReset(string email);

        Task<IEnumerable<string>> UsernameSearch(string username);

        UserLoginViewModel UserRepositoryLoginMiddleware(object apiResponseResult);

        User UserRepositoryUserMiddleware(object apiResponseResult);
    }
}
