using TT.Infrastructure.MainCore.Common.Entities;

namespace PicPals.DAL.Entities;

public class Tag : AuditableEntity
{
    public string Name { get; set; }
    public Guid PicId { get; set; }
    public virtual Pic Pic { get; set; }
}
