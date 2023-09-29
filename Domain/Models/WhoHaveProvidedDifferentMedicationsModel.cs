namespace Domain.Models;
public class WhoHaveProvidedDifferentMedicationsModel{
    public int MinimumNumberOfDifferentMedications { get; set; } = 0;
    public DateTime? InitialDate { get; set; } = null;
    public DateTime? FinalDate { get; set; } = null;
}
