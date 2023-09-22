using Domain.Entities.Generics;

namespace Domain.Entities;

public class ContactType : BaseEntityWithIntId {
  public string Name { get; set; }

  public Person Person { get; set; } // falta Id ?¿
  public ContactCategory ContactCategory { get; set; }

  public ICollection<Contact> Contacts {get;set;}
}