using Domain.Entities.Generics;

namespace Domain.Entities;
public class City: BaseEntityWithIntId{
  public string Name { get; set; }

  public int DepartmentId { get; set; }
  public Departament Department { get; set; }
  
  public ICollection<Address> Addresses {get;set;}
    
}