using Flurl.Http;
using ProjectWe.Models;
using ProjectWe.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Desktop.Services
{
    public class APIService
    {
        private readonly string _resource = null;
        private readonly string _baseUrl = "https://localhost:44397/api/";

        public static AppUser User = null;

        public APIService(string resource)
        {
            _resource = resource;
        }

        public async Task<T> GetList<T>(object search = null)
        {
            var query = "";
            if (search != null)
            {
                query = await search.ToQueryString();
            }

            return await $"{_baseUrl}{_resource}?{query}".WithOAuthBearerToken(User?.Token).GetJsonAsync<T>();
        }

        public async Task<T> Get<T>(object id)
        {
            return await $"{_baseUrl}{_resource}/{id}".WithOAuthBearerToken(User?.Token).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            return await $"{_baseUrl}{_resource}".WithOAuthBearerToken(User?.Token).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object request)
        {
            return await $"{_baseUrl}{_resource}/{id}".WithOAuthBearerToken(User?.Token).PutJsonAsync(request).ReceiveJson<T>();
        }

        // Authentication Endpoints
        public async Task<Models.AppUser> SignIn(object request)
        {
            return await $"{_baseUrl}users/signin".PostJsonAsync(request).ReceiveJson<Models.AppUser>();
        }
    }
}
