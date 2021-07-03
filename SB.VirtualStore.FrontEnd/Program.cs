using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SB.VirtualStore.FrontEnd.Services;
using SB.VirtualStore.FrontEnd.Models;

namespace SB.VirtualStore.FrontEnd
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped(sp => new HttpClient()
            {
                /// Publicado
                BaseAddress = new Uri("http://localhost:9096")

                /// No publicado
              //BaseAddress= new Uri("https://localhost:44399")
            });

            builder.Services.AddScoped<IServiceWeather, ServiceWeather>();
            builder.Services.AddScoped<IServiceRole, ServiceRole>();
            builder.Services.AddScoped<IServiceConfiguration, ServiceConfiguration>();
            builder.Services.AddScoped<IAuthService<AuthRequest, AuthResponse>, AuthService>();
            builder.Services.AddScoped<IServiceUsuario, UserService>();
            builder.Services.AddScoped<IServiceCategory, ServiceCategory>();
            builder.Services.AddScoped<IServiceProduct, ServiceProduct>();
            builder.Services.AddScoped<IGenderService, GenderService>();

            await builder.Build().RunAsync();
        }
    }
}


//https://www.youtube.com/watch?v=Diw5slnD99A&list=PL0kIvpOlieSNdIPZbn-mO15YIjRHY2wI9&index=2
//https://www.youtube.com/watch?v=9S0enMXDAZg


/// http://www.prowaretech.com/Computer/Blazor/Examples/Authentication/JWT
/// https://github.com/CuriousDrive/BookStores/blob/master/BlazorServerApp/BlazorServerApp/Services/