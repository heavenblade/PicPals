using PicPals.Common.Enums;
using TT.Infrastructure.MainCore.Common.Entities;

namespace PicPals.DAL.Entities;

public class Role : AuditableEntity
{
    public AppRoles RoleType { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; }
}
