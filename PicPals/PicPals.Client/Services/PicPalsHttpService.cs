using Microsoft.AspNetCore.Components;
using PicPals.Client.Model;
using PicPals.Client.Services.Interfaces;
using TT.Infrastructure.BlazorBase.Models;
using TT.Infrastructure.BlazorBase.Services;

namespace PicPals.Client.Services;

public class PicPalsHttpService : HttpService, IPicPalsHttpService
{
    public PicPalsHttpService(HttpClient httpClient, 
        NavigationManager navigationManager, 
        ISessionStorageService sessionStorageService, 
        AppConfiguration configuration,
        IServiceProvider serviceProvider, 
        StateManager stateManager) 
        : base(httpClient, navigationManager, sessionStorageService, configuration, serviceProvider, stateManager) { }

    protected override void SetBaseAddress()
    {
        _httpClient.BaseAddress = new Uri(((ClientSettings)_configuration).HostUrl);
    }
}
