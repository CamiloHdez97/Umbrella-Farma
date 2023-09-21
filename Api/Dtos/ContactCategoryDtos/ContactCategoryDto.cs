using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class ContactCategoryDto{
    [Required]
    public string Name { get; set; } = String.Empty;
}