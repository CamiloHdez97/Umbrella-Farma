using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class InventoryDto{
    [Required]
    public string Location { get; set; } = String.Empty;
    [Required]
    public int TotalStock { get; set; }
    [Required]
    public int MedicineInfoId { get; set; }

}