using PicPals.Client.Services;
using PicPals.Client.Services.Interfaces;
using TT.Infrastructure.BlazorBase.Services;

namespace PicPals.Client.Wires;

public class Bootstrapper : IBootstrapper
{
    public void Wire(IServiceCollection services)
    {
        services.AddHttpClient<IPicPalsHttpService, PicPalsHttpService>();
        services.AddScoped<IUserSearchService, UserSearchService>();
    }
}
