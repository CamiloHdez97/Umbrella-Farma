using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class SupplierTypeDto{
    [Required]
    public string Name { get; set; } = String.Empty;
}