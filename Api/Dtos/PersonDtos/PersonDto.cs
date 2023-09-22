using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class PersonDto{
    
    [Required]
    public string Name { get; set; } = String.Empty;
        
    [Required]
    public DateTime RegisterDate { get; set; }
    
    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    public int TypePersonId { get; set; }
    
    [Required]
    public int DocumentTypeId { get; set; }

}