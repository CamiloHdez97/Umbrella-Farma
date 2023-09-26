using Domain.Entities.Generics;

namespace Domain.Entities;
public class PersonType : BaseEntityWithIntId{
  public string Description { get; set; }
  public ICollection<Person> Persons {get; set;}
}