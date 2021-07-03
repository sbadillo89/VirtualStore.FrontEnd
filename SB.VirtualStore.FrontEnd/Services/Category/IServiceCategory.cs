using SB.VirtualStore.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public interface IServiceCategory
    {
        string token { get; set; }
        Task<IEnumerable<Category>> GetAllAsync(string requestUri);
        Task<Category> GetByIdAsync(string requestUri);
        Task<Category> PostAsync(string requestUri, Category category);
        Task<Category> PutAsync(string requestUri, Category category);
        Task<GlobalResponse> PutGlobalAsync(string requestUri, Category category);
    }
}
