using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class MedicineBrandWithIdDto: MedicineBrandDto{
    [Required]
    public int Id { get; set; }  
}