using Microsoft.EntityFrameworkCore;

namespace PicPals.DAL.Context;

public class AppDbContext : DbContext
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}
