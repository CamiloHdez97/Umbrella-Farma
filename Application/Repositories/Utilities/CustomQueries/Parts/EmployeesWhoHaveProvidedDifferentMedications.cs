using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    //? pendiente para refactorizar con el metodo ProvidersWhoHaveProvidedDifferentMedications 
    //*32. Empleado que ha vendido la mayor cantidad de medicamentos distintos en 2023. 
    public async Task<IEnumerable<object>> EmployeesWhoHaveProvidedDifferentMedications(WhoHaveProvidedDifferentMedicationsModel data = null){
        data ??= new(){
                MinimumNumberOfDifferentMedications = 0
            };
          var medicines =  await (from detail in _Context.Set<SaleDetail>()
            join sale in _Context.Set<Sale>() on detail.SaleId equals sale.Id
            join employee in _Context.Set<Employee>() on sale.EmployeeId equals employee.Id
            join person in _Context.Set<Person>() on employee.PersonId equals person.Id
            join medicine in _Context.Set<Medicine>() on detail.MedicineId equals medicine.Id
            join inventory in _Context.Set<Inventory>() on medicine.InventoryId equals inventory.Id
            join info in _Context.Set<MedicineInfo>() on inventory.MedicineInfoId equals info.Id
            select new {
                Employee = person.Name,
                info.Name,                
                sale.SaleDate
            }).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.SaleDate <= data.FinalDate  && 
                    x.SaleDate >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.SaleDate >= data.InitialDate ).ToList();
            } 
        }

        return from medicine in medicines
            group medicine by medicine.Employee into supplierGrups
            let medicineGroups = from supplierGrup in supplierGrups
                group supplierGrup by supplierGrup.Name into medicineGroups
                let TotalMedicines = medicineGroups.Count()
                select new {
                    medicineGroups.First().Name,
                    TotalMedicines
                }
            let TotalMedications = medicineGroups.Sum(a => a.TotalMedicines)
            let NumberOfDifferentMedications = medicineGroups.Count()
            where NumberOfDifferentMedications >= data.MinimumNumberOfDifferentMedications
            select new {
                supplierGrups.First().Employee,
                TotalMedications,
                NumberOfDifferentMedications,
                Medications = medicineGroups
            };
    }
}