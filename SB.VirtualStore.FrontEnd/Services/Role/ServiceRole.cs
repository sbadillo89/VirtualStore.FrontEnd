using Newtonsoft.Json;
using SB.VirtualStore.FrontEnd.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public class ServiceRole : IServiceRole
    {
        public string token { get; set; }
        private readonly HttpClient _httpClient;
        private readonly Repository.Request<Role> Request;

        public ServiceRole(HttpClient httpClient)
        {
            _httpClient = httpClient;
            Request = new Repository.Request<Role>(_httpClient);
        }
        public async Task<IEnumerable<Role>> GetAllAsync(string requestUri)
        {
            return await Request.GetAllAsync(requestUri, token);
        }
       
        public async Task<Role> PostAsync(string requestUri, Role role)
        {
            return await Request.PostAsync(requestUri, role, token);
        }

        public async Task<Role> PutAsync(string requestUri, Role role)
        { 
            return await Request.PutAsync(requestUri, role, token);
        }

        public async Task<Role> GetByIdAsync(string requestUri)
        {
            return await Request.GetByIdAsync(requestUri, token);
        }
    }
}
