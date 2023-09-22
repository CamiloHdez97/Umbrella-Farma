using Domain.Entities.Generics;

namespace Domain.Entities;
public class User: BaseEntityWithIntId {
    public string UserName { get; set; } 
    public string Password { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string AccessToken { get; set; } = String.Empty;
    public string RefreshToken { get; set; } = String.Empty;

    public int RoleId { get; set; }
    public Role Role {get;set;}
    
    public int PersonId { get; set; }
    public Person Person {get; set; }
}
