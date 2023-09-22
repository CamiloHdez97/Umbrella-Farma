using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class ShoppingDto{
    [Required]
    public DateTime ShoppingDate { get; set; }
    [Required]
    public int SupplierId { get; set; }
    [Required]
    public int EmployeeId { get; set; }

}