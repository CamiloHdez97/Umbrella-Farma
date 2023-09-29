namespace Domain.Models;
public class MedicinesByPriceAndStockModel{
    public float? Price { get; set; } = null;
    public int? Stock { get; set; } = null;
    public bool? HasAHigherPrice { get; set; } = null;
    public bool? HasAHigherStock { get; set; } = null;
}
