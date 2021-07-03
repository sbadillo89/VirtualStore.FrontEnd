using SB.VirtualStore.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public interface IServiceConfiguration
    {
        string token { get; set; }
        Task<IEnumerable<ConfigurationSite>> GetAsync(string requestUri);
    }
}
