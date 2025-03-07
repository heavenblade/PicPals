using Microsoft.EntityFrameworkCore;
using PicPals.Common.Services.Interfaces;
using TT.Infrastructure.MainCore.DAL.Extensions;

namespace PicPals.DAL.Context;

public class AppDbContext : DbContext
{
    private readonly IPicPalsSharedService sharedService;

    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options,
        IPicPalsSharedService sharedService)
        : base(options) 
    {
        this.sharedService = sharedService;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        Helpers.AppendMappings(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
