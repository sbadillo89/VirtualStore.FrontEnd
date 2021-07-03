using SB.VirtualStore.FrontEnd.Models;
using SB.VirtualStore.FrontEnd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public class GenderService : IGenderService
    {
        public string token { get; set; }

        HttpClient HttpClient;
        private readonly Repository.Request<Gender> request;
        public GenderService()
        {

        }
        public GenderService(HttpClient httpClient)
        {
            HttpClient = httpClient;
            request = new Request<Gender>(httpClient);
        }
        public Task<IEnumerable<Gender>> GetAllAsync(string url)
        {
            return request.GetAllAsync(url, token);
        }

        public Task<Gender> GetByIdAsync(string url, string id)
        {
            return request.GetByIdAsync(url + id, token);
        }
    }
}
