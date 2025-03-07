using PicPals.Common.Projections;

namespace PicPals.Services.Interfaces;

public interface IUserSearchService
{
    UserSearchProjection GetUserByEmail(string email);
    UserSearchProjection GetUserByUsername(string username);
}
