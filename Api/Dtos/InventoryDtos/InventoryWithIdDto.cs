using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class InventoryWithIdDto: InventoryDto{
    [Required]
    public int Id { get; set; }  
}