using Domain.Entities.Generics;

namespace Domain.Entities;

public class MedicineBrand : BaseEntityWithIntId {
  public string Name { get; set; }
  public ICollection<MedicineInfo> MedicineInfos{get; set;}
}