using BlazorDay3.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDay3
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped<IService<ProductDTO>, ProductService>();
            builder.Services.AddScoped<IService<Category>, CategoryService>();

            builder.Services.AddScoped(sp =>
                new HttpClient
                {
                    BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["WebAPIProvider"])
                });

            await builder.Build().RunAsync();
        }
    }
}
