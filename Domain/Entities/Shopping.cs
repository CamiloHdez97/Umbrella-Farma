using Domain.Entities.Generics;

namespace Domain.Entities;

public class Shopping : BaseEntityWithIntId {
  public DateTime ShoppingDate { get; set; }

  public int SupplierId { get; set; }
  public Supplier Supplier { get; set; }

  public int EmployeeId { get; set; }
  public Employee Employee { get; set; }

  //M:M medicine-shopping
  public ICollection<Medicine> Medicines {get; set;}
  public ICollection<ShoppingDetail> ShoppingDetails {get; set;}
}