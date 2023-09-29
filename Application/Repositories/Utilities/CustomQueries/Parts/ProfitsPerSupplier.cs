using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    //*16. Ganancia total por proveedor en 2023 (asumiendo un campo precioCompra en Compras).
    public async Task<IEnumerable<object>> ProfitsPerSupplier(ProfitsPerSupplierModel data = null){

        var medicines =  await (
            from detail in _Context.Set<ShoppingDetail>()
            join medicine in _Context.Set<Medicine>() on detail.MedicineId equals medicine.Id
            join inventory in _Context.Set<Inventory>() on medicine.InventoryId equals inventory.Id
            join info in _Context.Set<MedicineInfo>() on  inventory.MedicineInfoId equals info.Id
            join shopping in _Context.Set<Shopping>() on detail.ShoppingId equals shopping.Id
            join supplier in _Context.Set<Supplier>() on shopping.SupplierId equals supplier.Id
            join person in _Context.Set<Person>() on supplier.PersonId equals person.Id
            let Price = info.Price - (info.Price * (info.Discount / 100))
            select new {
                person.Name,
                Price,
                Date = shopping.ShoppingDate
            }
        ).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.Date <= data.FinalDate  && 
                    x.Date >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.Date >= data.InitialDate ).ToList();
            } 
        }

        var res =  from supplier in medicines
            group supplier by supplier.Name into supplierGroup
            let Units = supplierGroup.Count()
            let Total = supplierGroup.Sum(x => x.Price)
            select new {
                supplierGroup.First().Name,
                Units,
                Total = Total.ToString("c")
            };

        if(data?.ProviderName != null){
            return res.Where(x => x.Name.Trim().ToLower() == data.ProviderName.Trim().ToLower() );
        }
        return res;
    }
}