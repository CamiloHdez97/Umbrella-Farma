using Domain.Entities.Generics;

namespace Domain.Entities;

public class Person : BaseEntityWithIntId {
  public string Name { get; set; }

  public DateTime RegisterDate { get; set; }
  public DateTime BirthDate { get; set; }

  public Eps PersonEps { get; set; }//1:1 Eps
  public User User { get; set; }//1:1 User
  public Employee Employees {get; set;}//1:1

  public int DocumentTypeId { get; set; }//M:1 DocumentType
  public DocumentType DocumentType { get; set; }

  public int TypePersonId { get; set; }//M:1 TypePerson
  public TypePerson TypePerson { get; set; }

  public ICollection<Sale> Sales { get; set; }//1:M Sales
  public ICollection<Supplier> Suppliers { get; set; }//1:M Suppliers

  public ICollection<Contact> Contacts {get; set;}//M:M contact
  public ICollection<ContactType> ContactType { get; set; }
  public ICollection<ContactCategory> ContactCategory { get; set; }


}