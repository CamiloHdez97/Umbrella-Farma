using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class CityWithIdDto: CityDto{
    [Required]
    public int Id { get; set; }  
}