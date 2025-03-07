using TT.Infrastructure.MainCore.Common.Entities;

namespace PicPals.DAL.Entities;

public class User : AuditableEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public Guid LoginInfoId { get; set; }
    public virtual LoginInfo LoginInfo { get; set; }
}
