using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PicPals.DAL.Entities;
using TT.Infrastructure.MainCore.DAL.Mappings;

namespace PicPals.DAL.Mappings;

public class PicMapping : AuditableMapping<Pic>
{
    public override void Configure(EntityTypeBuilder<Pic> builder)
    {
        base.Configure(builder);
        builder.Property(p => p.Path).HasMaxLength(1024);
        builder.Property(p => p.Title).HasMaxLength(40);
        builder.Property(p => p.Title).HasMaxLength(40);
    }
}
