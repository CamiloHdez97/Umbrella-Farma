using Domain.Entities.Generics;

namespace Domain.Entities;

public class Medicine : BaseEntityWithIntId {
  public DateTime CreationDate { get; set; }
  public DateTime ExpirationDate { get; set; }

  // medicine info es importante ?¿

  public int InventoryId { get; set; }
  public Inventory Inventory { get; set; }

  public int StateId { get; set; }
  public State State { get; set; }

  //M:M medicine-shopping
  public ICollection<Shopping> Shoppings {get; set;}
  public ICollection<ShoppingDetail> ShoppingDetails { get; set; }

  //M:M medicine-sale
  public ICollection<Sale> Sales {get; set;}
  public ICollection<SaleDetail> SaleDetails { get; set; }

}