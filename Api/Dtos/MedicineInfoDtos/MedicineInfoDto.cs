using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class MedicineInfoDto: MedicineInfoSimpleDto{            
    [Required]
    public bool RequiredRecipe { get; set; }
    
    [Required]
    public int MedicineBrandId { get; set; }
    
    [Required]
    public int MedicinePresentationId { get; set; }
    
    [Required]
    public int MedicineCategoryId { get; set; }

}