using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class DocumentTypeWithIdDto: DocumentTypeDto{
    [Required]
    public int Id { get; set; }  
}