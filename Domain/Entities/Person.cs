using Domain.Entities.Generics;

namespace Domain.Entities;

public class Person : BaseEntityWithIntId {
  public string Name { get; set; }

  public DateTime RegisterDate { get; set; }
  public DateTime BirthDate { get; set; }
  public string DocumentNumber { get; set; }

  public Eps PersonEps { get; set; }//1:1 Eps
  public User User { get; set; }//1:1 User
  public Employee Employee {get; set;}//1:1

  public int DocumentTypeId { get; set; }//M:1 DocumentType
  public DocumentType DocumentType { get; set; }

  public int PersonTypeId { get; set; }//M:1 PersonType
  public PersonType PersonType { get; set; }

  public ICollection<Address> Addresses { get; set; }
  public ICollection<Sale> Sales { get; set; }//1:M Sales
  public ICollection<Supplier> Suppliers { get; set; }//1:M Suppliers
  public ICollection<Contact> Contacts {get; set;}
}