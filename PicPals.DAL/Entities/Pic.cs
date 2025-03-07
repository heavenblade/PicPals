using TT.Infrastructure.MainCore.Common.Entities;

namespace PicPals.DAL.Entities;

public class Pic : AuditableEntity
{
    public string Path { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid TagId { get; set; }
    public virtual Tag Tag { get; set; }
}
