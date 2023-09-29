using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    
    public async Task<IEnumerable<object>> MedicationsThatHaveNotBeenSold(int? year){
        year ??= DateTime.Now.Year;
        var medicines =  await (from medicine in _Context.Set<Medicine>()
            join info in _Context.Set<MedicineInfo>() on medicine.Inventory.MedicineInfo.Id 
            equals info.Id
            join state in _Context.Set<State>() on medicine.StateId equals state.Id
            where !medicine.Sales.Any() && state.Description == "default" && medicine.CreationDate.Year == year
            select new {
                medicine.Id,
                info.Name,
                medicine.ExpirationDate,
                medicine.CreationDate,
            }).ToListAsync();
        return from medicine in medicines
            group medicine by medicine.Name into medicineGroup
            let units = medicineGroup.Count()
            select new {
                Name = medicineGroup.First().Name,
                TotalUnits = units
            };
    }

}