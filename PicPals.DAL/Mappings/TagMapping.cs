using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PicPals.DAL.Entities;
using TT.Infrastructure.MainCore.DAL.Mappings;

namespace PicPals.DAL.Mappings;

public class TagMapping : AuditableMapping<Tag>
{
    public override void Configure(EntityTypeBuilder<Tag> builder)
    {
        base.Configure(builder);
        builder.Property(p => p.Name).HasMaxLength(50);

        builder.HasOne(p => p.Pic)
            .WithMany()
            .HasForeignKey(p => p.PicId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
