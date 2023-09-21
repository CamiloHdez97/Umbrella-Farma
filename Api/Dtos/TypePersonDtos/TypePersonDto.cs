using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class TypePersonDto{
    [Required]
    public string Description { get; set; } = String.Empty;
}