using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    //*7 Total de medicamentos vendidos por cada proveedor.
    public async Task<IEnumerable<object>> TotalMedicationsSoldByProvider(){
        var medicines = await (
                from detail in _Context.Set<ShoppingDetail>()
                let medicineInfo = detail.Medicine.Inventory.MedicineInfo
                join supplier in _Context.Set<Supplier>() on detail.Shopping.SupplierId equals supplier.Id
                join Person in _Context.Set<Person>() on supplier.PersonId equals Person.Id
                select  new {                                
                    medicineInfo.Name,
                    Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100)),
                    medicineInfo.Description,
                    medicineInfo.Image,
                    Supplier = Person.Name
                }).ToListAsync();
        return from medicine in medicines 
            group medicine by medicine.Supplier into medicineGroup               
            select new {
                medicineGroup.First().Supplier,
                TotalSaled = medicineGroup.Sum(x => x.Price).ToString("c"),
                TotalUnits = medicineGroup.Count()
            };
    }
   
}