using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    public async Task<IEnumerable<object>> TotalMedicineSold(TotalMedicineSoldModel conditions = null){
        var medicines = await (from detail in _Context.Set<SaleDetail>()
            join sale in _Context.Set<Sale>() on detail.SaleId equals sale.Id
            join medicine in _Context.Set<MedicineInfo>() on detail.Medicine.Inventory.MedicineInfo.Id equals medicine.Id
            let Price = medicine.Price - (medicine.Price * (medicine.Discount / 100))
            select new {
                sale.SaleDate,                
                medicine.Name,
                medicine.Description,
                medicine.Image,
                Price
            }).ToListAsync();
        if (conditions != null && conditions?.InitialDate != null){            
            if (conditions.FinalDate != null && conditions.FinalDate < conditions.InitialDate){
                medicines = medicines.Where(x => 
                    x.SaleDate >= conditions.InitialDate && 
                    x.SaleDate <= conditions.FinalDate
                ).ToList();
            }else{
                medicines = medicines.Where(x => x.SaleDate >= conditions.InitialDate).ToList();
            }
        }
        var res =  from medicine in medicines 
            group medicine by medicine.Name into medicineGroup
            let TotalSale = medicineGroup.Sum(x => x.Price)
            let Units = medicineGroup.Count()
            let salesAverage = TotalSale / Units            
            orderby TotalSale descending
            select new {
                medicineGroup.First().Name,
                salesAverage,
                TotalSale = TotalSale.ToString("c"),
                Units
            };
        if (conditions?.GetLessSales == true){
            var avarange = res.Average(x => x.salesAverage);
            return res.Where(x => x.salesAverage <= avarange);
        }
        return res;
    }
    
}