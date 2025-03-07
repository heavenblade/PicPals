using Microsoft.Extensions.DependencyInjection;
using PicPals.DAL.Services;
using PicPals.DAL.Services.Interfaces;
using TT.Infrastructure.MainCore.Common.Interfaces.Repositories;
using TT.Infrastructure.MainCore.CommonCore.Services;

namespace PicPals.DAL.Wires;

public class Bootstrapper : IBootstrapper
{
    public void Wire(IServiceCollection services)
    {
        services.AddScoped<IContextResolver, ContextResolver>();
        services.AddScoped<IPicPalsDatabaseFactory, PicPalsDatabaseFactory>();
    }
}
