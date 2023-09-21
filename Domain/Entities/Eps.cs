using Domain.Entities.Generics;

namespace Domain.Entities;

public class Eps {

  public int PersonId { get; set; }
  public Person Person { get; set; }

  public int EpsTypeId { get; set; }
  public EpsType EpsType { get; set; }

  public ICollection<Recipe> Recipes {get; set;}

  public ICollection<Employee> Employees {get; set;}
  public ICollection<EpsEmployee> EpsEmployees {get; set;}
}