using Domain.Entities.Generics;

namespace Domain.Entities;

public class Supplier {
  public int SupplierTypeId { get; set; }
  public SupplierType SupplierType { get; set; }

  public int PersonId { get; set; }
  public Person Person { get; set; }

  public ICollection<Shopping> Shoppings {get; set;}

}