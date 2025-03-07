using Microsoft.AspNetCore.Mvc;
using PicPals.Common.Projections;
using PicPals.Services.Interfaces;

namespace PicPals.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserSearchController : BlazorBaseController
{
    private readonly IUserSearchService userSearchService;

    public UserSearchController(IUserSearchService userSearchService) : base()
    {
        this.userSearchService = userSearchService;
    }

    [HttpPost(nameof(SearchUserByEmail))]
    public ActionResult<UserSearchProjection> SearchUserByEmail([FromBody] string email) =>
        userSearchService.GetUserByEmail(email);

    [HttpPost(nameof(SearchUserByUsername))]
    public ActionResult<UserSearchProjection> SearchUserByUsername([FromBody] string username) =>
        userSearchService.GetUserByUsername(username);
}
