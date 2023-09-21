using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class MedicineWithIdDto: MedicineDto{
    [Required]
    public int Id { get; set; }  
}