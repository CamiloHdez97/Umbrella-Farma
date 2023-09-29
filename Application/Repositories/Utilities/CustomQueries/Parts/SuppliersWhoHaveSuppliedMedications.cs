using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    public async Task<IEnumerable<object>> SuppliersWhoHaveSuppliedMedications(SuppliersWhoHaveSuppliedMedicationsModel data = null){
        var medicines = await (from detail in _Context.Set<ShoppingDetail>()
            join shopping in _Context.Set<Shopping>() on detail.ShoppingId equals shopping.Id
            join medicineInfo in _Context.Set<MedicineInfo>() on detail.Medicine.Inventory.MedicineInfo.Id equals medicineInfo.Id
            join supplier in _Context.Set<Supplier>() on shopping.SupplierId equals supplier.Id
            join person in _Context.Set<Person>() on supplier.PersonId equals person.Id
            let Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100))
            select new {
                Supplier = person.Name,
                medicineInfo.Name,
                shopping.ShoppingDate,
                Price,
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

        var res =  from medicine in medicines 
            group medicine by medicine.Supplier into medicineGroup
            let MoneyInvested = medicineGroup.Sum(x => x.Price)
            let TotalPurchases = medicineGroup.Count()
            orderby TotalPurchases descending
            let medicinesTotals = from medicineTotal in medicineGroup
                group medicineTotal by medicineTotal.Name into medicineTotalGroup
                select  new {
                    medicineTotalGroup.First().Name,
                    TotalPurchases = medicineTotalGroup.Sum(x => x.Price).ToString("c"), 
                    medicinesTotals = medicineTotalGroup.Count()
                }
            select new {
                medicineGroup.First().Supplier,  
                medicines = medicinesTotals,           
                MoneyInvested = MoneyInvested.ToString("c"),
                TotalPurchases
            };    

        if(data?.IsUnder != false){
            return res.Where(x => x.TotalPurchases <= data.MinimalMedications);    
        }
        return res.Where(x => x.TotalPurchases >= data.MinimalMedications);     
    }

}