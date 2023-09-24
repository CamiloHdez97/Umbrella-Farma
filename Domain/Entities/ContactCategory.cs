using Domain.Entities.Generics;

namespace Domain.Entities;

public class ContactCategory : BaseEntityWithIntId {
  public string Name { get; set; }

  public ICollection<Contact> Contacts {get;set;}
}