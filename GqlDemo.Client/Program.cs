using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GqlDemo.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services
                .AddSharesClient()
                .ConfigureHttpClient(httpClient => httpClient.BaseAddress = new Uri("https://localhost:5001/graphql"))
                .ConfigureWebSocketClient(client => client.Uri = new Uri("wss://localhost:5001/graphql")); ;

            await builder.Build().RunAsync();
        }
    }
}
