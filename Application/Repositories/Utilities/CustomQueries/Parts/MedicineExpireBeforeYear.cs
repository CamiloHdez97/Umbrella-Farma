using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    //*4. Obtener recetas médicas emitidas después del 1 de enero de 2023.
     public async Task<IEnumerable<object>> MedicineExpireBeforeYear(int year){
        return await (
            from medicineInfo in _Context.Set<MedicineInfo>()
                join inventory in _Context.Set<Inventory>() on medicineInfo.Id equals inventory.MedicineInfoId
                join medicine in _Context.Set<Medicine>() on inventory.Id equals medicine.InventoryId
                where medicine.ExpirationDate.Year > year
                select new
                {
                    id = medicine.Id,
                    Medicine = medicineInfo.Name,
                    Expiration = medicine.ExpirationDate
                }).ToListAsync();            
    }

}