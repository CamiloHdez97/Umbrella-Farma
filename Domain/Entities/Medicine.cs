using Domain.Entities.Generics;

namespace Domain.Entities;

public class Medicine : BaseEntityWithIntId {
  public DateTime CreationDate { get; set; }
  public DateTime ExpirationDate { get; set; }

  public int MedicineInfoId { get; set; }
  public MedicineInfo MedicineInfo { get; set; }

  public int StateId { get; set; }
  public State State { get; set; }

  public ICollection<SaleDetail> SaleDetail { get; set; }
  public ICollection<ShoppingDetail> ShoppingDetail { get; set; }

}