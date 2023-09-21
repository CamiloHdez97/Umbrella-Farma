using Domain.Entities.Generics;

namespace Domain.Entities;
public class City: BaseEntityWithIntId{
  public string Name { get; set; }

  public int DepartmentId { get; set; }
  public Department Department { get; set; }
  
  public ICollection<Address> Addresses {get;set;}
    
}