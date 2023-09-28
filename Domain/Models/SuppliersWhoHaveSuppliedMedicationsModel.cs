namespace Domain.Models;
public class SuppliersWhoHaveSuppliedMedicationsModel{
    public int MinimalMedications { get; set; } = 0;
    public bool IsUnder { get; set; } = false;
    public DateTime? InitialDate { get; set; } = null;
    public DateTime? FinalDate { get; set; } = null;
}