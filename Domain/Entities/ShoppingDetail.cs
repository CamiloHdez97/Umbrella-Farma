
namespace Domain.Entities;

public class ShoppingDetail{
  public int MedicineId { get; set; }
  public Medicine Medicine { get; set; }

  public int ShoppingId { get; set; }
  public Shopping Shopping { get; set; }
}