using System.ComponentModel.DataAnnotations;

namespace Api.Dtos.Auth;
public class Token{        
    [Required(ErrorMessage = "Refresh Token is required")]
    public string? RefreshToken { get; set; }   
}