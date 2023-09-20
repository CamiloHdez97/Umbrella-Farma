using Domain.Entities.Generics;

namespace Domain.Entities;
public class Role: BaseEntityIdInt{    
    public IEnumerable<User> Users { get; set; } = new HashSet<User>();
}