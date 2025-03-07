using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PicPals.DAL.Entities;
using TT.Infrastructure.MainCore.DAL.Mappings;

namespace PicPals.DAL.Mappings;

public class UserToPicMapping : AuditableMapping<UserToPic>
{
    public override void Configure(EntityTypeBuilder<UserToPic> builder)
    {
        base.Configure(builder);

        builder.HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(p => p.Pic)
            .WithMany()
            .HasForeignKey(p => p.PicId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
