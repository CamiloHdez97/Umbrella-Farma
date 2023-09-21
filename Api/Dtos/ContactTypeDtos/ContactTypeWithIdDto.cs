using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class ContactTypeWithIdDto: ContactTypeDto{
    [Required]
    public int Id { get; set; }  
}