using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class ShoppingDto{
    [Required]
    public string ShoppingDate { get; set; } = String.Empty;
    [Required]
    public int SupplierId { get; set; }
    [Required]
    public int EmployeeId { get; set; }

}