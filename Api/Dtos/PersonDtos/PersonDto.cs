using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class PersonDto{
    
    [Required]
    public string Name { get; set; } = String.Empty;
        
    [Required]
    public string RegisterDate { get; set; } = String.Empty;
    
    [Required]
    public string BirthDate { get; set; } = String.Empty;

    [Required]
    public int TypePersonId { get; set; }
    
    [Required]
    public int DocumentTypeId { get; set; }

}