using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;
public class StateDto{
    [Required]
    public string Name { get; set; }  = String.Empty;
}