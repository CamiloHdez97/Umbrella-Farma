using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class SupplierTypeWithIdDto: SupplierTypeDto{
    [Required]
    public int Id { get; set; }  
}