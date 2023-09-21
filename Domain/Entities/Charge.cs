using Domain.Entities.Generics;

namespace Domain.Entities;

public class Charge : BaseEntityWithIntId {
  public string Name { get; set; }
  
  public ICollection<Employee> Employees {get; set;}
}