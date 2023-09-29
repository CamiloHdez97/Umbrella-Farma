namespace Domain.Models;
public class ProfitsPerSupplierModel{
    public string ProviderName { get; set; } = null;
    public DateTime? InitialDate { get; set; } = null;
    public DateTime? FinalDate { get; set; } = null;    
}
