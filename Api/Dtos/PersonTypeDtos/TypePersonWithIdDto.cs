using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class PersonTypeWithIdDto: PersonTypeDto{
    [Required]
    public int Id { get; set; }  
}