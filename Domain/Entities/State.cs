using Domain.Entities.Generics;

namespace Domain.Entities;

public class State : BaseEntityWithIntId {
  public string Name { get; set; }

  public ICollection<Medicine> Medicines { get; set; }
}