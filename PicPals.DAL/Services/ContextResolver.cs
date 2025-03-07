using PicPals.DAL.Context;
using TT.Infrastructure.MainCore.Common.Interfaces.Repositories;

namespace PicPals.DAL.Services;

public class ContextResolver : IContextResolver
{
    public Type ContextType => typeof(AppDbContext);
}
