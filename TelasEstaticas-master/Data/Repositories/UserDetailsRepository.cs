using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Accounts;
using WeDancin.Domain.Interfaces.Accounts;
using System.Net.Http.Json;
using WeDancin.Domain.Entities.Helpers.API;
using System.Text.Json;
using WeDancin.Frontend.Customers.Data.Entity;
using Newtonsoft.Json;

namespace WeDancin.Frontend.Customers.Data.Repositories
{
    public class UserDetailsRepository : IUserDetailsRepository
    {
        private readonly HttpClient _http;
        private readonly ILocalStorageService _localStorageService;
        private string url = "https://api.accounts.wedancin.h2tecnologia.com/api/UserDetails/";

        public UserDetailsRepository(HttpClient http, ILocalStorageService localStorageService)
        {
            _http = http;
            _localStorageService = localStorageService;
        }

        public UserDetails UserRepositoryUserDetailsMiddleware(object apiResponseResult)
        {
            return JsonConvert.DeserializeObject<UserDetails>(Convert.ToString(apiResponseResult));
        }

        public async Task<APIResponse> CreateAsync(UserDetails userDetails)
        {
            var userToken = await _localStorageService.GetItem<UserLoginViewModel>("wedancin");

            _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", userToken.Token);

            var createdUserDetails = await _http.PostAsJsonAsync<UserDetails>(url, userDetails);

            if (createdUserDetails == null)
                return null;

            var createdx = await createdUserDetails.Content.ReadFromJsonAsync<APIResponse>();

            return createdx;
        }

        public async Task<APIResponse> GetAsync(Guid id)
        {
            var user = await _localStorageService.GetItem<UserLoginViewModel>("wedancin");

            _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", user.Token);

            return await _http.GetFromJsonAsync<APIResponse>(url + id);
        }

        public async Task<APIResponse> UpdateAsync(UserDetails userDetails)
        {
            var userToken = await _localStorageService.GetItem<UserLoginViewModel>("wedancin");

            _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", userToken.Token);

            var edited = await _http.PutAsJsonAsync<UserDetails>(url + userDetails.UserId, userDetails);

            if (edited == null)
                return null;

            var editedx = await edited.Content.ReadFromJsonAsync<APIResponse>();

            return editedx;
        }



























        //public UserLoginViewModel UserRepositoryLoginMiddleware(object apiResponseResult)
        //{
        //    return JsonConvert.DeserializeObject<UserLoginViewModel>(Convert.ToString(apiResponseResult));
        //}

        //public User UserRepositoryUserMiddleware(object apiResponseResult)
        //{
        //    return JsonConvert.DeserializeObject<User>(Convert.ToString(apiResponseResult));
        //}

        //public async Task<APIResponse> CreateAsync(User user)
        //{
        //    var created = await _http.PostAsJsonAsync<User>(url, user);

        //    if (created == null)
        //        return null;

        //    var createdx = await created.Content.ReadFromJsonAsync<APIResponse>();

        //    return createdx;
        //}

        //public async Task<APIResponse> UpdateAsync(User user)
        //{
        //    var userToken = await _localStorageService.GetItem<UserLoginViewModel>("wedancin");

        //    _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", userToken.Token);

        //    var edited = await _http.PutAsJsonAsync<User>(url + user.Id, user);

        //    if (edited == null)
        //        return null;

        //    var editedx = await edited.Content.ReadFromJsonAsync<APIResponse>();

        //    return editedx;
        //}

        //public async Task<APIResponse> GetAsync(Guid id)
        //{
        //    var user = await _localStorageService.GetItem<UserLoginViewModel>("wedancin");

        //    _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", user.Token);

        //    return await _http.GetFromJsonAsync<APIResponse>(url + id);
        //}

        //public async Task<APIResponse> LoginAsync(UserLogin userLogin)
        //{
        //    HttpResponseMessage callResponse = await _http.PostAsJsonAsync("https://api.accounts.wedancin.h2tecnologia.com/api/Login", userLogin);

        //    var apiResponse = await callResponse.Content.ReadFromJsonAsync<APIResponse>();

        //    return apiResponse;
        //}


        //public Task<bool> ConfirmMailAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Guid> PasswordReset(string email)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool UserLoginExists(string email)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> UsernameExists(string username)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<string>> UsernameSearch(string username)
        //{
        //    throw new NotImplementedException();
        //}



    }
}