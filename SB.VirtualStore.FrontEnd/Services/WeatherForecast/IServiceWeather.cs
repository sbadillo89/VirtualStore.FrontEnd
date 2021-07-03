using SB.VirtualStore.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public interface IServiceWeather
    {
        Task<IEnumerable<Weather>> getWeather();
    }
}
