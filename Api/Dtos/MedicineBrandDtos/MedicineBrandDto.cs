using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class MedicineBrandDto{
    [Required]
    public string Name { get; set; } = String.Empty;
}