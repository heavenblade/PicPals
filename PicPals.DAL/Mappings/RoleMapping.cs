using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PicPals.Common.Enums;
using PicPals.DAL.Entities;
using TT.Infrastructure.MainCore.DAL.Mappings;

namespace PicPals.DAL.Mappings;

public class RoleMapping : AuditableMapping<Role>
{
    public override void Configure(EntityTypeBuilder<Role> builder)
    {
        base.Configure(builder);
        builder.Property(c => c.RoleType).HasConversion(p => p.ToString(),
            c => (AppRoles)Enum.Parse(typeof(AppRoles), c)).HasMaxLength(50);

        builder.HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }

}
