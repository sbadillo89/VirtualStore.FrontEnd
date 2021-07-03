using SB.VirtualStore.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SB.VirtualStore.FrontEnd.Services
{
    public class ServiceCategory : IServiceCategory
    {
        public string token { get; set; }
        private readonly HttpClient httpClient;
        private readonly Repository.Request<Category> Request;

        public ServiceCategory(HttpClient http)
        {
            httpClient = http;
            Request = new Repository.Request<Category>(httpClient);
        }
        public async Task<IEnumerable<Category>> GetAllAsync(string requestUri)
        {
            return await Request.GetAllAsync(requestUri, token);
        }

        public async Task<Category> GetByIdAsync(string requestUri)
        { 
            return await Request.GetByIdAsync(requestUri, token);
        }

        public async Task<Category> PostAsync(string requestUri, Category newCategory)
        {
            return await Request.PostAsync(requestUri, newCategory, token);
        }

        public async Task<Category> PutAsync(string requestUri, Category category)
        {
            return await Request.PutAsync(requestUri, category, token);
        }
        public async Task<GlobalResponse> PutGlobalAsync(string requestUri, Category category)
        {
            return await Request.PutGlobalAsync(requestUri, category, token);
        }
    }
}

