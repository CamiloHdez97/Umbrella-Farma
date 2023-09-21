using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class PersonWithIdDto: PersonDto{
    [Required]
    public int Id { get; set; }  
}