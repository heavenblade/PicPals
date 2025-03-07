using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using PicPals.Client.Model;

namespace PicPals.Client.Pages.Account;

public partial class Login
{
    [CascadingParameter]
    private HttpContext HttpContext { get; set; }

    [SupplyParameterFromForm]
    private LoginViewModel loginViewModel { get; set; }

    private string errorMessage;

    public async Task LoginUser()
    {

    }
}
