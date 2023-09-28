using Domain.Entities.Generics;

namespace Domain.Entities;

public class ShoppingDetail:MovementDetaill{
  

  public int ShoppingId { get; set; }
  public Shopping Shopping { get; set; }
}