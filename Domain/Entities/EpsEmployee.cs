namespace Domain.Entities;
public class EpsEmployee {
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public int EpsId { get; set; }
    public Eps Eps { get; set; }
}