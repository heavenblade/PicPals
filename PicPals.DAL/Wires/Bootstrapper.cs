using Microsoft.Extensions.DependencyInjection;
using PicPals.DAL.Repositories;
using PicPals.DAL.Repositories.Interfaces;
using PicPals.DAL.Services;
using PicPals.DAL.Services.Interfaces;
using TT.Infrastructure.MainCore.Common.Interfaces.Repositories;
using TT.Infrastructure.MainCore.CommonCore.Services;
using TT.Infrastructure.MainCore.DAL.Interfaces;

namespace PicPals.DAL.Wires;

public class Bootstrapper : IBootstrapper
{
    public void Wire(IServiceCollection services)
    {
        services.AddScoped<IContextResolver, ContextResolver>();
        services.AddScoped<IDataBaseFactory, PicPalsDatabaseFactory>();
        services.AddScoped<IPicPalsDatabaseFactory, PicPalsDatabaseFactory>();

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserToPicRepository, UserToPicRepository>();
        services.AddScoped<IPicRepository, PicRepository>();
        services.AddScoped<ILoginInfoRepository, LoginInfoRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
    }
}
