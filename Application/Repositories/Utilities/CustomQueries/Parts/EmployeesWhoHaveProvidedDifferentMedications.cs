using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    public Task<IEnumerable<object>> EmployeesWhoHaveProvidedDifferentMedications(WhoHaveProvidedDifferentMedicationsModel data = null)
    {
        throw new NotImplementedException();
    }
}