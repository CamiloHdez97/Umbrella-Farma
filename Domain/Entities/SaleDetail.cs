using Domain.Entities.Generics;

namespace Domain.Entities;

public class SaleDetail{
  public int MedicineId { get; set; }
  public Medicine Medicine { get; set; }

  public int SaleId { get; set; }
  public Sale Sale { get; set; }
}  