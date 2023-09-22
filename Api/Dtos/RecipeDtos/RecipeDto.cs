using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class RecipeDto{
    
    [Required]
    public DateTime RecipeDate { get; set; }
    
    [Required]
    public DateTime ExpirationDate { get; set; }
    
    [Required]
    public string Detail { get; set; } = String.Empty;
    
    [Required]
    public int SaleId { get; set; }
    
    [Required]
    public int EpsId { get; set; }

}