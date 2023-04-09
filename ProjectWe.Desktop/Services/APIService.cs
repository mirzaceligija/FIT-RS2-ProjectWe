using Flurl.Http;
using ProjectWe.Desktop.Properties;
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
        private readonly string _baseUrl = Settings.Default.ApiURL; //http://localhost:44397/api/;

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
            try
            {
                return await $"{_baseUrl}{_resource}".WithOAuthBearerToken(User?.Token).PostJsonAsync(request).ReceiveJson<T>();
            } catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();
                var stringBuilder = new StringBuilder();
                foreach (var err in errors)
                {
                    stringBuilder.AppendLine($"{err.Key}, ${string.Join(",", err.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Update<T>(object id, object request)
        {
            try
            {
                return await $"{_baseUrl}{_resource}?id={id}".WithOAuthBearerToken(User?.Token).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();
                var stringBuilder = new StringBuilder();
                foreach (var err in errors)
                {
                    stringBuilder.AppendLine($"{err.Key}, ${string.Join(",", err.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        // Authentication Endpoints
        public async Task<Models.AppUser> SignIn(object request)
        {
            return await $"{_baseUrl}users/signin".PostJsonAsync(request).ReceiveJson<Models.AppUser>();
        }
    }
}
