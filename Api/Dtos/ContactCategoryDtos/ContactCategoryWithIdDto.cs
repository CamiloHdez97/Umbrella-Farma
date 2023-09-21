using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class ContactCategoryWithIdDto: ContactCategoryDto{
    [Required]
    public int Id { get; set; }  
}