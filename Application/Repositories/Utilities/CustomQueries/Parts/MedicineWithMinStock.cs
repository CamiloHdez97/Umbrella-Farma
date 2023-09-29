using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    //*1 Obtener todos los medicamentos con menos de 50 unidades en stock    
    public async Task<IEnumerable<object>> MedicineWithMinStock (int minStock){
        return await (
            from medicineItem in _Context.Set<MedicineInfo>()
            select new {
                Medicine = new{
                    medicineItem.Id,
                    medicineItem.Name,
                    medicineItem.Price,
                    medicineItem.Discount,
                    medicineItem.Image,
                    medicineItem.RequiredRecipe,
                    MedicineBrand = medicineItem.MedicineBrand.Name,
                    MedicinePresentation = medicineItem.MedicinePresentation.Name,
                    MedicineCategory = medicineItem.MedicineCategory.Name
                },
                TotalStock = _Context.Set<Medicine>().Where(x => x.Inventory.MedicineInfo.Name == medicineItem.Name && x.StateId == 1).Count()
            }
        ).ToListAsync();        
    }
    
}