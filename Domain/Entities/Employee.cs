using Domain.Entities.Generics;

namespace Domain.Entities;

public class Employee: BaseEntityWithIntId{
  public int ChargeId { get;set; }
  public Charge Charge { get;set; }
  
  public int PersonId { get; set; }
  public Person Person { get; set; }

  public ICollection<Sale> Sales {get; set;}

}