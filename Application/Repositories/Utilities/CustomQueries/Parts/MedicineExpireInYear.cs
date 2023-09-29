using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    public async Task<IEnumerable<object>> MedicineExpireInYear(int year){
        return await (
            from medicineInfo in _Context.Set<MedicineInfo>()
                join inventory in _Context.Set<Inventory>() on medicineInfo.Id equals inventory.MedicineInfoId
                join medicine in _Context.Set<Medicine>() on inventory.Id equals medicine.InventoryId
                where medicine.ExpirationDate.Year == year
                select new
                {
                    id = medicine.Id,
                    Medicine = medicineInfo.Name,
                    Expiration = medicine.ExpirationDate
                }).ToListAsync();            
    }

}