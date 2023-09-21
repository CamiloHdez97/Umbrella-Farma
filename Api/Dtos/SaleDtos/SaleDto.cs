using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class SaleDto{
  
  [Required]
  public string SaleDate { get; set; } = String.Empty;
  
  [Required]
  public int EmployeeId { get; set; }
  
  [Required]
  public int PersonId { get; set; }
    
}


