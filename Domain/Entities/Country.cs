using Domain.Entities.Generics;

namespace Domain.Entities;
public class Country: BaseEntityWithIntId{
  public string Name { get; set; }
  
  public ICollection<Department> Departments {get;set;}
  
}