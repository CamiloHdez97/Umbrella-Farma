using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class AddressDto{
    
    [Required]
    public string Description { get; set; } = String.Empty;
    
    [Required]
    public int PersonId { get; set; }
    
    [Required]
    public int CityId { get; set; }

}