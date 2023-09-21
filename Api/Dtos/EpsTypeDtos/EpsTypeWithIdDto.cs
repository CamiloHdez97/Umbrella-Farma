using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class EpsTypeWithIdDto: EpsTypeDto{
    [Required]
    public int Id { get; set; }  
}