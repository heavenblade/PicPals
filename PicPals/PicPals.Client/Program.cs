using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PicPals.Client.Model;
using TT.Infrastructure.BlazorBase.Helpers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services
    .AddOptions()
    .AddAuthorizationCore()
    .AddSingleton(sp => new HttpClient()
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
    });

await builder.WireAll<ClientSettings>("blazorAppSettings");

await builder.Build().RunAsync();
