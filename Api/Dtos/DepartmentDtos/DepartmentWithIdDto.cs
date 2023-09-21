using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class DepartmentWithIdDto: DepartmentDto{
    [Required]
    public int Id { get; set; }  
}