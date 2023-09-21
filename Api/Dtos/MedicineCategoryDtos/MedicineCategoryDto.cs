using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class MedicineCategoryDto{
    [Required]
    public string Name { get; set; } = String.Empty;
}