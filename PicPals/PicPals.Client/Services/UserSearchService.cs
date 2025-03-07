using PicPals.Client.Services.Interfaces;
using PicPals.Common.Projections;

namespace PicPals.Client.Services;

public class UserSearchService : IUserSearchService
{
    private readonly HttpClient client;
    private readonly IPicPalsHttpService httpService;

    public UserSearchService(HttpClient client, 
        IPicPalsHttpService httpService)
    {
        this.client = client;
        this.httpService = httpService;
    }

    public async Task<UserSearchProjection> SearchUserByEmail(string email) =>
        await httpService.Post<UserSearchProjection>($"api/UserSearch/SearchUserByEmail", email);

    public async Task<UserSearchProjection> SearchUserByUsername(string username) => 
        await httpService.Post<UserSearchProjection>($"api/UserSearch/SearchUserByUsername", username);
}
