using Microsoft.AspNetCore.Http;
using PicPals.Common.Services.Interfaces;
using TT.Infrastructure.MainCore.CommonCore.Services;

namespace PicPals.Common.Services;

public class PicPalsSharedService : SharedService, IPicPalsSharedService
{
    public PicPalsSharedService(IServiceProvider serviceProvider,
        IHttpContextAccessor httpContext) 
        : base(serviceProvider, httpContext) { }
}
