using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class RecipeDto{
    
    [Required]
    public string RecipeDate { get; set; } = String.Empty;
    
    [Required]
    public string ExpirationDate { get; set; } = String.Empty;
    
    [Required]
    public string Detail { get; set; } = String.Empty;
    
    [Required]
    public int SaleId { get; set; }
    
    [Required]
    public int EpsId { get; set; }

}