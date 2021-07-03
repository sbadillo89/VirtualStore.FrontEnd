using SB.VirtualStore.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public class ServiceConfiguration : IServiceConfiguration
    {
        public string token { get ; set; }
        private readonly HttpClient _httpClient;

        public ServiceConfiguration(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ConfigurationSite>> GetAsync(string requestUri)
        {
            var requestMsg = new HttpRequestMessage(HttpMethod.Get, requestUri);
            requestMsg.Headers.Add("Authorization", "Bearer " + token);
            var response = await _httpClient.SendAsync(requestMsg);
            if (response.IsSuccessStatusCode)
            { 
                return await response.Content.ReadFromJsonAsync<ConfigurationSite[]>();
            }

            return null;
        }
    }
}
