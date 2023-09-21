using Domain.Entities.Generics;

namespace Domain.Entities;
public class TypePerson: BaseEntityWithIntId{
  public string Description { get; set; }
  public ICollection<Person> Person {get; set;}
}