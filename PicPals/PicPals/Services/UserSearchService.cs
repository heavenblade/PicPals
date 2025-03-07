using PicPals.Common.Projections;
using PicPals.DAL.Entities;
using PicPals.DAL.Repositories.Interfaces;
using PicPals.Services.Interfaces;

namespace PicPals.Services;

public class UserSearchService : IUserSearchService
{
    private readonly IUserRepository userRepository;

    public UserSearchService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public UserSearchProjection GetUserByEmail(string email)
    {
        var user = userRepository.Get(x => x.LoginInfo.Email.Equals(email));

        if (user == null)
            return null; // to change

        return Map(user);
    }

    public UserSearchProjection GetUserByUsername(string username)
    {
        var user = userRepository.Get(x => x.LoginInfo.Username.Equals(username));

        if (user == null)
            return null; // to change

        return Map(user);
    }

    public UserSearchProjection Map(User user) =>
        new()
        {
            Id = user.Id,
            Email = user.LoginInfo.Email,
            Username = user.LoginInfo.Username,
            Password = user.LoginInfo.Password,
            Age = user.Age
        };
}
