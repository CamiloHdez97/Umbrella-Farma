using Domain.Entities;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public partial class CustomQueriesManager: ICustomQueriesManager{
    private static DataContext _Context;
    
    public CustomQueriesManager(DataContext context)=> _Context = context;
    

    private static IEnumerable<MedicineDetailTotalModel> MovementDetail(IEnumerable<MedicineInfo> data){
        var medicines =(from detail in data             
            select new MedicineDetailModel{                                
                Name = detail?.Name,
                Price = detail.Price - (detail.Price * (detail.Discount / 100)),
                Description = detail?.Description,
                Image = detail?.Image,
            }).ToList();

        return from medicine in medicines
            group medicine by medicine.Name into grouped
            select new MedicineDetailTotalModel{
                Medicine = grouped.First(),
                Total = grouped.Count()
            };
    }    
}
