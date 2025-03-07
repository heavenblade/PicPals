using TT.Infrastructure.MainCore.DAL.Interfaces;

namespace PicPals.DAL.Services.Interfaces;

public interface IPicPalsDatabaseFactory : IDataBaseFactory
{
    void Initialize(Type[] seeds);
}
