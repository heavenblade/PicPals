using PicPals.DAL.Entities;
using PicPals.DAL.Repositories.Interfaces;
using TT.Infrastructure.MainCore.Common.Interfaces.Repositories;
using TT.Infrastructure.MainCore.CommonCore.Services;
using TT.Infrastructure.MainCore.DAL.Interfaces;
using TT.Infrastructure.MainCore.DAL.Repositories;

namespace PicPals.DAL.Repositories;

public class PicRepository : RepositoryBase<Pic>, IPicRepository
{
    public PicRepository(IDataBaseFactory dataBaseFactory,
        IContextResolver contextResolver, 
        ISharedService sharedService) 
        : base(dataBaseFactory, contextResolver, sharedService) { }
}
