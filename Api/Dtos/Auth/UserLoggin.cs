using System.ComponentModel.DataAnnotations;

namespace Api.Dtos.Auth;
public class UserLoggin{
    [Required(ErrorMessage = "Username is required")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; set; }

}
