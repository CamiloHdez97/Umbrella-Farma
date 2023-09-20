using System.ComponentModel.DataAnnotations;

namespace Api.Dtos.Auth;
public class UserSignup: UserLoggin{
    [EmailAddress]
    [Required(ErrorMessage = "Email is required")]
    public string? Email { get; set; }
}
