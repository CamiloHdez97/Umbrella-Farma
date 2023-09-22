using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class PersonTypeDto{
    [Required]
    public string Description { get; set; } = String.Empty;
}