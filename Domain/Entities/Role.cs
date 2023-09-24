using Domain.Entities.Generics;

namespace Domain.Entities;
public class Role: BaseEntityWithIntId{    
    public string Description { get; set; }
    
    public IEnumerable<User> Users { get; set; } = new HashSet<User>();
    public ICollection<UserRol> UserRols { get; set; } = new HashSet<UserRol>();
}