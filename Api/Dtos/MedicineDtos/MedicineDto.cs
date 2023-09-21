using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class MedicineDto{
    [Required]
    public string CreationDate { get; set; } = String.Empty;
    [Required]
    public string ExpirationDate { get; set; } = String.Empty;
    [Required]
    public int InventoryId { get; set; }
    [Required]
    public int StateId { get; set; }
}