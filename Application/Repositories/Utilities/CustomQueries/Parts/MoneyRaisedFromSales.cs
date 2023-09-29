using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    //*8 Cantidad total de dinero recaudado por las ventas de medicamentos.
    public async Task<float> MoneyRaisedFromSales(string medicineName = null){

        var medicines =  await (from detail in _Context.Set<SaleDetail>()
            let medicine = detail.Medicine.Inventory.MedicineInfo
            select new {
                medicine.Name,
                Price = medicine.Price - (medicine.Price * (medicine.Discount / 100)),
            }).ToListAsync();
        
        var res = from medicine in medicines
            group medicine by medicine.Name into medicineGroup
            select new {
                medicineGroup.First().Name,
                TotalPrice = medicineGroup.Sum(x => x.Price) * medicineGroup.Count(),                
            };

        if(medicineName!= null){
            return res.Where(x => x.Name == medicineName).Sum(x => x.TotalPrice);
        }
        return res.Sum(x => x.TotalPrice);

    }
    
}