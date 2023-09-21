using Domain.Entities.Generics;

namespace Domain.Entities;

public class MedicinePresentation : BaseEntityWithIntId {
  public string Name { get; set; }
  public ICollection<MedicineInfo> Medicines { get; set; }
}