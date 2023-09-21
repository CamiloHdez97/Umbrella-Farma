using Domain.Entities.Generics;

namespace Domain.Entities;

public class ContactCategory : BaseEntityWithIntId {
  public string Name { get; set; }

  public Person Person { get; set; }
  public ContactType ContactType { get; set; }
  
  public ICollection<Contact> Contacts {get;set;}
}