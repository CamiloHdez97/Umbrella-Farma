using Domain.Entities.Generics;

namespace Domain.Entities;

public class Recipe : BaseEntityWithStringId {
  public DateTime RecipeDate { get; set; }
  public DateTime ExpirationDate { get; set; }
  public string Detail { get; set; }

  public int SaleId { get; set; }
  public Sale Sale { get; set; }

  public int EpsId { get; set; }
  public Eps Eps { get; set; }
}