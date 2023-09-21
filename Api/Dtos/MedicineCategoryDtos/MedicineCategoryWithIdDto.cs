using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class MedicineCategoryWithIdDto: MedicineCategoryDto{
    [Required]
    public int Id { get; set; }  
}