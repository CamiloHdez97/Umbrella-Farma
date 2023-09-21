using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class AddressWithIdDto: AddressDto{
    [Required]
    public int Id { get; set; }  
}