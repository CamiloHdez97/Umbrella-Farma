using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class EmployeeWithIdDto: EmployeeDto{
    [Required]
    public int Id { get; set; }  
}