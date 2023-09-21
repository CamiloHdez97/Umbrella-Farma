using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class EpsTypeDto{
    [Required]
    public string Name { get; set; } = String.Empty;
}