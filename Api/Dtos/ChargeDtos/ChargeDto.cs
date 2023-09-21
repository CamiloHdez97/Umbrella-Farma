using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class ChargeDto{
    [Required]
    public string Name { get; set; } = String.Empty;
}
