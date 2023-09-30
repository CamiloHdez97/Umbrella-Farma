using System.ComponentModel.DataAnnotations;

namespace Api.Dtos.Auth;
public class UserSignup: UserLoggin{
    [EmailAddress]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Nuber of Identity is requery")]
    public string DocumentNumber { get; set; }
}
