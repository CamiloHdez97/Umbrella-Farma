using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class EmployeeDto{
    [Required]
    public int ChargeId { get;set; }
    
    [Required]
    public int PersonId { get; set; }

}