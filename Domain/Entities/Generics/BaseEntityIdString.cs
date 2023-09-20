using Domain.Entities.Generics;

namespace Domain.Entities;
public class BaseEntityIdString:BaseWithName{
    public string Id { get; set; } = String.Empty;
}
