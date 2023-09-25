using Domain.Entities.Generics;

namespace Domain.Entities;

public class MedicineInfo : BaseEntityWithIntId {
  public string Name { get; set; }
  public string Description { get; set; }
  public float Price { get; set; }
  public float Discount { get; set; }
  public string Image { get; set; }
  public bool RequiredRecipe { get; set; }

  public int MedicineBrandId { get; set; }
  public MedicineBrand MedicineBrand { get; set; }

  public int MedicinePresentationId { get; set; }
  public MedicinePresentation MedicinePresentation { get; set; }
  
  public int MedicineCategoryId { get; set; }
  public MedicineCategory MedicineCategory { get; set; }


  public ICollection<Inventory> Inventories { get; set; }
  
}