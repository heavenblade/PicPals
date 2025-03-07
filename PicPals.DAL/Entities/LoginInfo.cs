using TT.Infrastructure.MainCore.Common.Entities;

namespace PicPals.DAL.Entities;

public class LoginInfo : AuditableEntity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime LastLogin { get; set; }
}
