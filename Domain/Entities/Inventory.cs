using Domain.Entities.Generics;

namespace Domain.Entities;

public class Inventory : BaseEntityWithIntId {
  public string Location { get; set; }
  public int MedicineInfoId { get; set; }
  public MedicineInfo MedicineInfo { get; set; }

  public ICollection<Medicine> Medicines { get; set; }
}