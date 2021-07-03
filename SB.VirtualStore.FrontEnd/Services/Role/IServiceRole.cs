using SB.VirtualStore.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public interface IServiceRole
    {
        string token { get; set; }
        Task<IEnumerable<Role>> GetAllAsync(string requestUri);

        Task<Role> GetByIdAsync(string requestUri);

        Task<Role> PostAsync(string requestUri, Role role);

        Task<Role> PutAsync(string requestUri, Role role);

    }
}
