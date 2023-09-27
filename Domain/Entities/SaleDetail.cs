using Domain.Entities.Generics;

namespace Domain.Entities;

public class SaleDetail: MovementDetaill{
  public int SaleId { get; set; }
  public Sale Sale { get; set; }
}  