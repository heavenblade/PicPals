using PicPals.Common.Projections;

namespace PicPals.Client.Services.Interfaces;

public interface IUserSearchService
{
    Task<UserSearchProjection> SearchUserByEmail(string email);
    Task<UserSearchProjection> SearchUserByUsername(string username);
}
