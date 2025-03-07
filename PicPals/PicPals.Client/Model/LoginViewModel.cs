using System.ComponentModel.DataAnnotations;

namespace PicPals.Client.Model;

public class LoginViewModel
{
    [EmailAddress]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Provide email")]
    public string? Email { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Provide email")]
    public string? Username { get; set; }

    [DataType(DataType.Password)]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Provide email")]
    public string? Password { get; set; }
}
