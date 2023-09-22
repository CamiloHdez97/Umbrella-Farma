using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class MedicineDto{
    [Required]
    public DateTime CreationDate { get; set; }
    [Required]
    public DateTime ExpirationDate { get; set; } 
    [Required]
    public int InventoryId { get; set; }
    [Required]
    public int StateId { get; set; }
} 