using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class ShoppingWithIdDto: ShoppingDto{
    [Required]
    public int Id { get; set; }  
}