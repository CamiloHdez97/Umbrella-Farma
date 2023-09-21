using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class CountryWithIdDto: CountryDto{
    [Required]
    public int Id { get; set; }  
}