using PicPals.Services;
using PicPals.Services.Interfaces;
using TT.Infrastructure.MainCore.CommonCore.Services;

namespace PicPals.Wires;

public class Bootstrapper : IBootstrapper
{
    public void Wire(IServiceCollection services)
    {
        services.AddScoped<IUserSearchService, UserSearchService>();
    }
}
