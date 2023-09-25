using Domain.Entities.Generics;

namespace Domain.Entities;

public class State : BaseEntityWithIntId {
  public string Description { get; set; }

  public ICollection<Medicine> Medicines { get; set; }
}