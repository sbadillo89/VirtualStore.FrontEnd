
using SB.VirtualStore.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public class UserService : IServiceUsuario
    {  
        public readonly HttpClient httpClient;
        private readonly Repository.Request<User> Request;

        public UserService(HttpClient http)
        {
            httpClient = http;
            Request = new Repository.Request<User>(httpClient);
        }

         
        public async Task<IEnumerable<User>> GetAllAsync(string requestUri, string token)
        {
            return await Request.GetAllAsync(requestUri, token);
        }

        public async Task<User> GetByIdAsync(string requestUri, string token)
        {
            return await Request.GetByIdAsync(requestUri, token);
        }

        public async Task<User> PostAsync(string requestUri, User newUser, string token)
        {
            return await Request.PostAsync(requestUri, newUser, token);
        } 
        public async Task<User> PutAsync(string requestUri, User newUser, string token)
        {
            return await Request.PutAsync(requestUri, newUser, token);
        } 
    }
}
