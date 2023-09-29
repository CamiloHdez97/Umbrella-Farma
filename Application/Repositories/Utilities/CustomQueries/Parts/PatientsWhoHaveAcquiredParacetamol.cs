using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;
public partial class CustomQueriesManager{
    //*12 Pacientes que han comprado Paracetamol.
    public async Task<IEnumerable<object>> PatientsWhoHaveAcquiredParacetamol(string Patients = null){
        var medicines =  await (from detail in _Context.Set<SaleDetail>()
            join person in _Context.Set<Person>() on detail.Sale.PersonId equals person.Id
            join medicine in _Context.Set<MedicineInfo>() on detail.Medicine.Inventory.MedicineInfo.Id equals medicine.Id
            let Price = medicine.Price - (medicine.Price * (medicine.Discount / 100))
            select new {
                Patient = person.Name,
                medicine.Name,
                medicine.Description,
                medicine.Image,
                Price
            }).ToListAsync();

        var res = from medicine in medicines 
            group medicine by medicine.Patient into medicineGroup
            let TotalUnits = medicineGroup.Count()
            let TotalPrice = medicineGroup.Sum(x => x.Price)             
            select new {
                medicineGroup.First().Patient,
                medicineGroup.First().Name,
                TotalUnits,
                TotalPrice
            };
        if(Patients != null){
            return res.Where(x => x.Patient.Trim().ToLower() == Patients.Trim().ToLower());
        }
        return res;
    }
    
}