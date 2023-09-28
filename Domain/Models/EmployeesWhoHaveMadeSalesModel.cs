namespace Domain.Models;
public class EmployeesWhoHaveMadeSalesModel{
    public int MinimumSales { get; set; } = 0;
    public bool IsUnder { get; set; } = false;
    public DateTime? InitialDate { get; set; } = null;
    public DateTime? FinalDate { get; set; } = null;
}
