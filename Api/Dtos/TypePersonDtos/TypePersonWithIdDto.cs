using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class TypePersonWithIdDto: TypePersonDto{
    [Required]
    public int Id { get; set; }  
}