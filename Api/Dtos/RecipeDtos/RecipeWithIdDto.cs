using System.ComponentModel.DataAnnotations;
namespace Api.Dtos;
public class RecipeWithIdDto: RecipeDto{
    [Required]
    public String Id { get; set; }  = String.Empty;
}