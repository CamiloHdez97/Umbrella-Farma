namespace Domain.Entities;

public class Contact {
  public string Description { get; set; }

  public int PersonId { get; set; }
  public Person Person { get; set; }

  public int ContactTypeId { get; set; }
  public ContactType ContactType { get; set; }

  public int ContactCategoryId { get; set; }
  public ContactCategory ContactCategory { get; set; }
}