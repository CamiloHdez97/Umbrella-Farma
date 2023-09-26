using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class MedicineInfoWithIdDto: MedicineInfoDto{            
    [Required]
    public int Id { get; set; }
}