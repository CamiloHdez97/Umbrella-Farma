using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    //? pendiente para refactorizar con el metodo EmployeesWhoHaveProvidedDifferentMedications 
    public async Task<IEnumerable<object>> ProvidersWhoHaveProvidedDifferentMedications(WhoHaveProvidedDifferentMedicationsModel data = null){
        if(data == null){
            data = new(){
                MinimumNumberOfDifferentMedications = 0
            };
        }
        var medicines =  await (from detail in _Context.Set<ShoppingDetail>()
            join shopping in _Context.Set<Shopping>() on detail.ShoppingId equals shopping.Id
            join supplier in _Context.Set<Supplier>() on shopping.SupplierId equals supplier.Id
            join person in _Context.Set<Person>() on supplier.PersonId equals person.Id
            join medicine in _Context.Set<Medicine>() on detail.MedicineId equals medicine.Id
            join inventory in _Context.Set<Inventory>() on medicine.InventoryId equals inventory.Id
            join info in _Context.Set<MedicineInfo>() on inventory.MedicineInfoId equals info.Id
            select new {
                Supplier = person.Name,
                info.Name,                
                shopping.ShoppingDate,
            }).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.ShoppingDate <= data.FinalDate  && 
                    x.ShoppingDate >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.ShoppingDate >= data.InitialDate ).ToList();
            } 
        }

        return from medicine in medicines
            group medicine by medicine.Supplier into supplierGrups
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
                supplierGrups.First().Supplier,
                TotalMedications,
                NumberOfDifferentMedications,
                Medications = medicineGroups
            };
    }

}