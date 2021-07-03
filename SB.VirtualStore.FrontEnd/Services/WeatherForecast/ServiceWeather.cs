using SB.VirtualStore.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;

namespace SB.VirtualStore.FrontEnd.Services
{
    public class ServiceWeather : IServiceWeather
    {
        private readonly HttpClient _httpClient;

        public ServiceWeather(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Weather>> getWeather()
        {
            return await _httpClient.GetFromJsonAsync<Weather[]>("/weatherforecast"); 
        }
    }
}
