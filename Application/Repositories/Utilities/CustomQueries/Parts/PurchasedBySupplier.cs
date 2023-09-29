using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    public async Task<IEnumerable<object>> PurchasedBySupplier (MedicineInfoSupplierModel data ){
        var medicines =  await(from detail in _Context.Set<ShoppingDetail>()
            join supplier in _Context.Set<Supplier>() on detail.Shopping.SupplierId equals supplier.Id
            join person in _Context.Set<Person>() on supplier.PersonId equals person.Id
            join shopping in _Context.Set<Shopping>() on detail.ShoppingId equals shopping.Id
            let medicineInfo = detail.Medicine.Inventory.MedicineInfo
            let Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100))

            select new {
                Date = shopping.ShoppingDate,
                Supplier = person.Name,
                medicineInfo.Name,
                Price                
            }).ToListAsync();
            if (data.InitialDate != null){            
            if (data.FinalDate != null && data.FinalDate < data.InitialDate){
                medicines = medicines.Where(x => 
                    x.Date >= (
                        data.HasCoincidence
                            ?data.InitialDate 
                            :data.FinalDate) && 
                    x.Date <= (
                        data.HasCoincidence
                            ?data.FinalDate 
                            :data.InitialDate) 
                ).ToList();
            }else{
                medicines = medicines.Where(x => 
                    data.HasCoincidence
                        ? x.Date >= data.InitialDate
                        : x.Date <= data.InitialDate
                ).ToList();
            }
        }
        var res = from medicine in medicines
            group medicine by medicine.Supplier into medicineGroup
            let Total = medicineGroup.Sum(x => x.Price)
            let Units = medicineGroup.Count()
            select new {
                medicineGroup.First().Supplier,
                Total,
                Units
            };

        if (data.SupplierName != null){
            return res.Where(x => 
                data.HasCoincidence
                    ?x.Supplier == data.SupplierName
                    :x.Supplier != data.SupplierName
            );            
        }
        return res;
    } 
    
}