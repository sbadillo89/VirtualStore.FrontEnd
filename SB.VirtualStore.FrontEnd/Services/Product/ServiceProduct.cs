using SB.VirtualStore.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public class ServiceProduct : IServiceProduct
    {
        public string token { get; set; } 
        private readonly HttpClient _httpClient;
        private readonly Repository.Request<Product> Request;

        public ServiceProduct(HttpClient httpClient)
        {
            _httpClient = httpClient; 
            Request = new Repository.Request<Product>(_httpClient);
        }

        public Task<IEnumerable<Product>> GetAllAsync(string Url)
        {
            return Request.GetAllAsync(Url, token);
        }

        public Task<Product> GetByIdAsync(string Url, string productId)
        {
            return Request.GetByIdAsync(Url + productId, token);
        }

        public Task<Product> PostAsync(string Url, Product product)
        {
            return Request.PostAsync(Url, product, token);
        }

        public Task<Product> PutAsync(string Url, string productId, Product product)
        {
            return Request.PutAsync(Url + productId, product, token);
        }
    }
}
