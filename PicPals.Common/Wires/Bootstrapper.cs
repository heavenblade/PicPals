using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PicPals.Common.Models;
using PicPals.Common.Services;
using PicPals.Common.Services.Interfaces;
using TT.Infrastructure.MainCore.CommonCore.Extensions;
using TT.Infrastructure.MainCore.CommonCore.Services;

namespace PicPals.Common.Wires;

public class Bootstrapper : IBootstrapper
{
    public void Wire(IServiceCollection services)
    {
        var configuration = services.GetService<IConfiguration>();

        services.Configure<Settings>(configuration.GetSection("Configuration"));
        services.AddScoped(p => p.GetService<IOptionsSnapshot<Settings>>()!.Value);

        services.AddScoped<ISharedService, PicPalsSharedService>();
        services.AddScoped<IPicPalsSharedService, PicPalsSharedService>();
    }
}
