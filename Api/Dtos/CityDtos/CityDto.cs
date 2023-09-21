using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class CityDto{
    [Required]
    public string Name { get; set; } = String.Empty;
    
    [Required]
    public int DepartmentId { get; set; }
}