using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PicPals.DAL.Entities;
using TT.Infrastructure.MainCore.DAL.Mappings;

namespace PicPals.DAL.Mappings;

public class UserMapping : AuditableMapping<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);
        builder.Property(p => p.Name).HasMaxLength(60);
        builder.Property(p => p.Surname).HasMaxLength(80);

        builder.HasOne(p => p.LoginInfo)
            .WithMany()
            .HasForeignKey(p => p.LoginInfoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
