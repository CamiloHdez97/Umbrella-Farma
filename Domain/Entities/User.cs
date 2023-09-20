using Domain.Entities.Generics;

namespace Domain.Entities;
public class User: BaseEntityIdInt{    
    public string? Email { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
    public string? AccessToken { get; set; } = String.Empty;
    public string? RefreshToken { get; set; } = String.Empty;

    public int RoleId { get; set; }
    public Role? Role {get;set;}
}
