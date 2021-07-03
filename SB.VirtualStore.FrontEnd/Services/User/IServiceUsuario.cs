using SB.VirtualStore.FrontEnd.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public interface IServiceUsuario 
    {
        Task<IEnumerable<User>> GetAllAsync(string requestUri, string token);
        Task<User> GetByIdAsync(string requestUri, string token);
        Task<User> PostAsync(string requestUri, User user, string token);
        Task<User> PutAsync(string requestUri, User user, string token);
    }
}
