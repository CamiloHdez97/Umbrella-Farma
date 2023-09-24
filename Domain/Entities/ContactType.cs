using Domain.Entities.Generics;

namespace Domain.Entities;

public class ContactType : BaseEntityWithIntId {
  public string Name { get; set; }

  public ICollection<Contact> Contacts {get;set;}
}