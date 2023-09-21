using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class StateWithIdDto: StateDto{
    [Required]
    public int Id { get; set; }  
}