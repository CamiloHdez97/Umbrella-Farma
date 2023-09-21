using Domain.Entities.Generics;

namespace Domain.Entities;

public class SupplierType : BaseEntityWithIntId {
  public string Name { get; set; }
  public ICollection<Supplier> Suppliers{ get; set; }
}