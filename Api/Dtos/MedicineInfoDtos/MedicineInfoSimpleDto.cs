using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class MedicineInfoSimpleDto{
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
}
