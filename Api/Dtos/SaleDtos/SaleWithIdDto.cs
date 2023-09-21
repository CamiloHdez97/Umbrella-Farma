using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class SaleWithIdDto: SaleDto{
    [Required]
    public int Id { get; set; }  
}