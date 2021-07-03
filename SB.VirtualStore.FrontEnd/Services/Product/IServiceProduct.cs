using SB.VirtualStore.FrontEnd.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public interface IServiceProduct
    {
        string token { get; set; }
        Task<IEnumerable<Product>> GetAllAsync(string Url);
        Task<Product> GetByIdAsync(string Url, string productId);
        Task<Product> PutAsync(string Url, string productId, Product product);
        Task<Product> PostAsync(string Url, Product product);
    }
}
