using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DoggoApi.Services
{
    public static class RestService
    {
        private static HttpClient httpClient;

        static RestService()
        {
            httpClient = new HttpClient();
        }

        public static async Task<T> GetAsync<T>(string url)
        {
            var uri = new Uri(Path.Combine(url));
            HttpResponseMessage response = null;
            try
            {
                response = await httpClient.GetAsync(uri);
            }
            catch (Exception ex)
            {
                
            }
            var jsonResult = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<T>(jsonResult);
            return result;
        }
    }
}
