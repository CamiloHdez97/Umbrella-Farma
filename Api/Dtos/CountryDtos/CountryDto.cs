using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class CountryDto{
    [Required]
    public string Name { get; set; } = String.Empty;    
}