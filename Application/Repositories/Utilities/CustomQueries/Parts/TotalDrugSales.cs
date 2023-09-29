using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    //*5 Total de ventas del medicamento ‘Paracetamol’
    public async Task<IEnumerable<MedicineDetailTotalModel>> TotalDrugSales(string MedicineName){
        var data  = await (from detail in _Context.Set<SaleDetail>()
                join state in _Context.Set<State>() on detail.Medicine.StateId equals state.Id
                where detail.Medicine.Inventory.MedicineInfo.Name.Trim().ToLower() == MedicineName.Trim().ToLower() && state.Id == 1
                select detail.Medicine.Inventory.MedicineInfo
            ).ToListAsync();            
        return MovementDetail( data );
    }    
    
}