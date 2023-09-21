using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class ContactTypeDto{
    [Required]
    public string Name { get; set; } = String.Empty;  
}