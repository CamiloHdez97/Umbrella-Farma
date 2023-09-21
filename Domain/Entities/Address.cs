using Domain.Entities.Generics;

namespace Domain.Entities;
public class Address: BaseEntityWithIntId{
  public string Description { get; set; }

  public int PersonId { get; set; }
  public Person Person { get; set; }  

  public int CityId { get; set; }
  public City City { get; set; }  
}