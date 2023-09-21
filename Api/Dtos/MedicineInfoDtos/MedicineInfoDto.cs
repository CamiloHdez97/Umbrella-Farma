using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class MedicineInfoDto{
    
    [Required]
    public string Description { get; set; } = String.Empty;
    
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
    public int MedicineBrandId { get; set; }
    
    [Required]
    public int MedicinePresentationId { get; set; }
    
    [Required]
    public int MedicineCategoryId { get; set; }

}