using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkspertBooker.Model;
using System.Net.Http;

namespace EkspertBooker.DesktopAppUI
{
    public class APIService
    {
        private string _route = null;


        //private readonly string _URL = Properties.Settings.Default.APIUrl;

        private readonly string _URL = Properties.Settings.Default.APIUrl_TestRelease;


        public static string Username { get; set; }
        public static string Password { get; set; }

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_URL}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object insert)
        {
            var url = $"{_URL}/{_route}";
            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(insert).ReceiveJson<T>();
            return result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_URL}/{_route}/{id}";
            //url += id.ToQueryString(); //Dodavanje query parametara u GET request
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Update<T>(object id, object update)
        {
            var url = $"{_URL}/{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(update).ReceiveJson<T>();
            return result;
        }

        public async Task<T> Delete<T>(object id)
        {
            var url = $"{_URL}/{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).SendJsonAsync(HttpMethod.Delete, id).ReceiveJson<T>();
            return result;
        }
    }
}
