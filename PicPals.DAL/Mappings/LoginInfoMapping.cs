using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PicPals.DAL.Entities;
using TT.Infrastructure.MainCore.DAL.Mappings;

namespace PicPals.DAL.Mappings;

public class LoginInfoMapping : AuditableMapping<LoginInfo>
{
    public override void Configure(EntityTypeBuilder<LoginInfo> builder)
    {
        base.Configure(builder);
        builder.Property(p => p.Username).HasMaxLength(20);
        builder.Property(p => p.Email).HasMaxLength(250);
        builder.Property(p => p.Password).HasMaxLength(512);
    }
}
