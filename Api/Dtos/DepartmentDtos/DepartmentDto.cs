using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class DepartmentDto{
    [Required]
    public string Name { get; set; } = String.Empty;
    [Required]
    public int CountryId { get; set; }    
}

