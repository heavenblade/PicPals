using TT.Infrastructure.MainCore.Common.Entities;

namespace PicPals.DAL.Entities;

public class UserToPic : AuditableEntity
{
    public Guid UserId { get; set; }
    public virtual User User { get; set; }
    public Guid PicId { get; set; }
    public virtual Pic Pic { get; set; }
}
