using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    public async Task<IEnumerable<object>> MedicinesByPriceAndStock(MedicinesByPriceAndStockModel data = null){
        var medicines = await (from detail in _Context.Set<ShoppingDetail>()
            join medicine in _Context.Set<Medicine>() on detail.MedicineId equals medicine.Id
            join state in _Context.Set<State>() on medicine.StateId equals state.Id
            join inventory in _Context.Set<Inventory>() on medicine.InventoryId equals inventory.Id
            join medicineInfo in _Context.Set<MedicineInfo>() on inventory.MedicineInfo.Id equals medicineInfo.Id
            join shopping in _Context.Set<Shopping>() on detail.ShoppingId equals shopping.Id
            join supplier in _Context.Set<Supplier>() on shopping.SupplierId equals supplier.Id
            join person in _Context.Set<Person>() on supplier.PersonId equals person.Id
            where state.Id == 1 
            select new {
                Supplier = person.Name,
                medicineInfo.Name,
                medicineInfo.Price                
            }).ToListAsync();
        
        var res = from medicine in medicines
            group medicine by medicine.Name into medicineGroups
            let Stock = medicineGroups.Count()
            let TotalEstimated = medicineGroups.Sum(x => x.Price)
            let suppliers = from medicineGroup in medicineGroups
                group medicineGroup by medicineGroup.Supplier into supplierGrups
                let TotalPurchases = supplierGrups.Sum(x => x.Price).ToString("c")
                let Units = supplierGrups.Count()
                select new{
                    supplierGrups.First().Supplier,
                    Units
                }
            select new{
                medicineGroups.First().Name,
                Stock,                
                UnitPrice = medicineGroups.First().Price,
                TotalEstimated,
                suppliers
            };

        if(data?.Price != null && data?.Price >= 0){
            if(data.HasAHigherPrice == true){
                res = res.Where(x => x.UnitPrice >= data.Price).ToList();
            }else{
                res = res.Where(x => x.UnitPrice <= data.Price).ToList();
            }
        }
        if(data?.Stock != null && data?.Stock >= 0){
            if(data.HasAHigherStock == true){
                res = res.Where(x => x.Stock >= data.Stock).ToList();
            }else{
                res = res.Where(x => x.Stock <= data.Stock).ToList();
            }
        }

        return res.Select(res => new{
                res.Name,
                res.Stock,                
                UnitPrice = res.UnitPrice.ToString("c"),
                res.TotalEstimated,
                res.suppliers
            });
    }
    
}