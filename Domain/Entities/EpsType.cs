using Domain.Entities.Generics;

namespace Domain.Entities;

public class EpsType : BaseEntityWithIntId {
  public string Name { get; set; }

  public ICollection<Eps> Eps { get; set; }
}