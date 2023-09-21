using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class DocumentTypeDto{
    [Required]
    public string Description {get; set;} = String.Empty;    
}