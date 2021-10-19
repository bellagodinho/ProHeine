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
    public class UserRepository : IUserRepository
    {
        private readonly HttpClient _http;
        private readonly ILocalStorageService _localStorageService;
        private string url = "https://api.accounts.wedancin.h2tecnologia.com/api/User/";

        public UserRepository(HttpClient http, ILocalStorageService localStorageService)
        {
            _http = http;
            _localStorageService = localStorageService;
        }

        public UserLoginViewModel UserRepositoryLoginMiddleware(object apiResponseResult)
        {
            return JsonConvert.DeserializeObject<UserLoginViewModel>(Convert.ToString(apiResponseResult));
        }

        public User UserRepositoryUserMiddleware(object apiResponseResult)
        {
            return JsonConvert.DeserializeObject<User>(Convert.ToString(apiResponseResult));
        }

        public async Task<APIResponse> CreateAsync(User user)
        {
            var created = await _http.PostAsJsonAsync<User>(url, user);

            if (created == null)
                return null;

            var createdx = await created.Content.ReadFromJsonAsync<APIResponse>();

            return createdx;
        }

        public async Task<APIResponse> UpdateAsync(User user)
        {
            var userToken = await _localStorageService.GetItem<UserLoginViewModel>("wedancin");

            _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", userToken.Token);

            var edited = await _http.PutAsJsonAsync<User>(url + user.Id, user);

            if (edited == null)
                return null;

            var editedx = await edited.Content.ReadFromJsonAsync<APIResponse>();

            return editedx;
        }

        public async Task<APIResponse> GetAsync(Guid id)
        {
            var user = await _localStorageService.GetItem<UserLoginViewModel>("wedancin");

            _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", user.Token);

            var x =  await _http.GetFromJsonAsync<APIResponse>(url + id);

            return x;
        }

        public async Task<APIResponse> LoginAsync(UserLogin userLogin)
        {
            HttpResponseMessage callResponse = await _http.PostAsJsonAsync("https://api.accounts.wedancin.h2tecnologia.com/api/Login", userLogin);

            var apiResponse = await callResponse.Content.ReadFromJsonAsync<APIResponse>();

            return apiResponse;
        }


        public Task<bool> ConfirmMailAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> PasswordReset(string email)
        {
            throw new NotImplementedException();
        }

        public bool UserLoginExists(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UsernameExists(string username)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> UsernameSearch(string username)
        {
            throw new NotImplementedException();
        }


        //public async Task<UserLoginViewModel> Login(UserLogin userLogin)
        //{
        //    HttpResponseMessage response = await _http.PostAsJsonAsync("users/login", userLogin);

        //    return await response.Content.ReadFromJsonAsync<UserLoginViewModel>();
        //}

        //public bool UserExists(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool UserLoginExists(string email)
        //{
        //    throw new NotImplementedException();
        //}

        //public UserLoginViewModel UserLogin(UserLogin userLogin)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<string>> UsernameSearch(string username)
        //{
        //    var userToken = await _localStorageService.GetItem<UserLoginViewModel>("wedancin");

        //    _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", userToken.Token);

        //    HttpResponseMessage response = await _http.PostAsJsonAsync("users/search", searchString);

        //    return await response.Content.ReadFromJsonAsync<List<UserViewModel>>();
        //}



        //public Task<bool> UsernameExists(string username)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> ConfirmMailAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Guid> PasswordReset(string email)
        //{
        //    throw new NotImplementedException();
        //}

        //UserLoginViewModel IUserRepository.Login(UserLogin login)
        //{
        //    throw new NotImplementedException();
        //}
    }
}