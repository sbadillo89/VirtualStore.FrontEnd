using SB.VirtualStore.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public interface IGenderService
    {
        string token { get; set; }
        Task<IEnumerable<Gender>> GetAllAsync(string url);

        Task<Gender> GetByIdAsync(string url, string id);

    }
}
