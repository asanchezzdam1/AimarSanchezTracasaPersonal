using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Client.Services
{
    public class CRUDService : IIntegrationService
    {
        private static HttpClient _httpClient = new HttpClient();
        private static HttpClient _httpClientBorderapi = new HttpClient();
        public CRUDService()
        {
            _httpClient.BaseAddress = new Uri("http://localhost:57863");
            _httpClientBorderapi.BaseAddress = new Uri("https://www.boredapi.com");
                
        }
        public async Task Run()
        {
            await ejemploGet();
            await ejemploGetBorderApi();
        }

        private async Task ejemploGet()
        {
            var response = await _httpClient.GetAsync("api/movies");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            var movies = new List<Models.Movie>();
            movies = JsonConvert.DeserializeObject<List<Models.Movie>>(content);  
        }        
        
        private async Task ejemploGetBorderApi()
        {
            var response = await _httpClientBorderapi.GetAsync("api/activity/");
            var content = await response.Content.ReadAsStringAsync();

            var movies = new List<Models.Rootobject>();
            movies = JsonConvert.DeserializeObject<List<Models.Rootobject>>(content);  
        }
    }
}
