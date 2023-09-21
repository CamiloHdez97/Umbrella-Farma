using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class AddRolDto{
    [Required]    
    public string Username { get; set; } = null!;

    [Required]    
    public string Password { get; set; } = null!;

    [Required]    
    public string Rol { get; set; } = null!;
}
