namespace Domain.Models;
public class MedicineInfoSupplierModel{
    public string SupplierName { get; set; } = null;
    public DateTime? InitialDate { get; set; } = null;
    public DateTime? FinalDate { get; set; } = null;
    public bool HasCoincidence  { get; set; } = true;
}

