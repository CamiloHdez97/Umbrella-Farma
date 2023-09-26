using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class MedicineInfoWithTotalStock{
    [Required]
    public string Name { get; set; } = String.Empty;
    
    [Required]
    public float Price { get; set; }
    
    [Required]
    public float Discount { get; set; }
    
    [Required]
    public string Image { get; set; } = String.Empty;
    
    [Required]
    public bool RequiredRecipe { get; set; }
    
    [Required]
    public string MedicineBrand { get; set; }
    
    [Required]
    public string MedicinePresentation { get; set; }
    
    [Required]
    public string MedicineCategory { get; set; }

    [Required]    
    public int TotalStok { get; set;}
}
