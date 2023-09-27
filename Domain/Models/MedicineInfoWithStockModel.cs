namespace Application.Models;
public struct MedicineInfoWithStockModel{
    public string Name { get; set; }
    
    public float Price { get; set; }
    
    public float Discount { get; set; }
    
    public string Image { get; set; }
    
    public bool RequiredRecipe { get; set; }
    
    public string MedicineBrand { get; set; }
    
    public string MedicinePresentation { get; set; }
    
    public string MedicineCategory { get; set; }

    public  int TotalStok { get; set;}

}