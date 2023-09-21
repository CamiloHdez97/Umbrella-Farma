using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class ChargeWithIdDto:ChargeDto{
    [Required]
    public int Id { get; set; }
}
