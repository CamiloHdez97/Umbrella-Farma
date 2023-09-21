using Domain.Entities.Generics;

namespace Domain.Entities;

public class Sale : BaseEntityWithIntId {
  public DateTime SaleDate { get; set; }

  public int EmployeeId { get; set; }
  public Employee Employee { get; set; }

  public int PersonId { get; set; }
  public Person Person { get; set; }

  public ICollection<Recipe> Recipes {get; set;}
  public ICollection<SaleDetail> SaleDetails {get; set;}
}