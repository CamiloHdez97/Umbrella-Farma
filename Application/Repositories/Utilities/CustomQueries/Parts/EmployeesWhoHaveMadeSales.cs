using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
     public async Task<IEnumerable<object>> EmployeesWhoHaveMadeSales(EmployeesWhoHaveMadeSalesModel data = null){
        var medicines =  await (from detail in _Context.Set<SaleDetail>()
            join sale in _Context.Set<Sale>() on detail.SaleId equals sale.Id
            join employee in _Context.Set<Employee>() on sale.EmployeeId equals employee.Id
            join person in _Context.Set<Person>() on employee.PersonId equals person.Id
            join medicineInfo in _Context.Set<MedicineInfo>() on detail.Medicine.Inventory.MedicineInfoId equals medicineInfo.Id
            let Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100))
            select new {
                person.Name,
                Price,
                sale.SaleDate
            }).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.SaleDate <= data.FinalDate  && 
                    x.SaleDate >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.SaleDate >= data.InitialDate ).ToList();
            } 
        }

        var res = from medicine in medicines
            group medicine by medicine.Name into medicineGroup
            let RaisedMoney = medicineGroup.Sum(x => x.Price)
            let TotalSales = medicineGroup.Count()
            select new {
                medicineGroup.First().Name,
                RaisedMoney = RaisedMoney.ToString("c"),
                TotalSales
            };
        if(data?.IsUnder != false){
            return res.Where(x => x.TotalSales <= data.MinimumSales);    
        }
        return res.Where(x => x.TotalSales >= data.MinimumSales);
    }
    
}