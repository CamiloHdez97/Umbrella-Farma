using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class MedicinePresentationWithIdDto: MedicinePresentationDto{
    [Required]
    public int Id { get; set; }  
}