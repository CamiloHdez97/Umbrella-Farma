using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class SingUpDto{
    [Required]
    public string Username { get; set; } = null!;

    [Required]
    public string Email { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;    
}
