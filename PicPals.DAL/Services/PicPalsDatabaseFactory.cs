using PicPals.DAL.Context;
using PicPals.DAL.Services.Interfaces;
using TT.Infrastructure.MainCore.Common.Interfaces.Repositories;
using TT.Infrastructure.MainCore.DAL.Extensions;
using TT.Infrastructure.MainCore.DAL.Repositories;

namespace PicPals.DAL.Services;

public class PicPalsDatabaseFactory : DataBaseFactory, IPicPalsDatabaseFactory
{
    public PicPalsDatabaseFactory(IServiceProvider services, 
        IContextResolver contextResolver) 
        : base(services, contextResolver) { }

    public void Initialize(Type[] seeds)
    {
        _services.MigrateDb<AppDbContext>(seeds);
    }
}
