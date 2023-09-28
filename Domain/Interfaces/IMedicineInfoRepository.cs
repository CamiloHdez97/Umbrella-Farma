using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;
using Domain.Models;

namespace Domain.Interfaces;
public interface IMedicineInfoRepository: IGenericRepositoryIntId<MedicineInfo>{
    Task<IEnumerable<object>> MedicineWithMinStock(int minStock);
    //Task<IEnumerable<MedicineDetailTotalModel>> PurchasedBySupplier (MedicineInfoSupplierModel data);

    Task<IEnumerable<object>> PurchasedBySupplier (MedicineInfoSupplierModel data);
    Task<IEnumerable<MedicineDetailTotalModel>> TotalDrugSales(string MedicineName);
    Task<IEnumerable<object>> TotalMedicationsSoldByProvider();
    Task<float> MoneyRaisedFromSales(string medicineName = null);
    Task<IEnumerable<object>> TotalMedicineSold(TotalMedicineSoldModel data = null);        
    Task<IEnumerable<object>> EmployeesWhoHaveMadeSales(EmployeesWhoHaveMadeSalesModel data = null);        
    Task<IEnumerable<object>> SuppliersWhoHaveSuppliedMedications(SuppliersWhoHaveSuppliedMedicationsModel data = null);
    Task<IEnumerable<object>> PatientsWhoHaveAcquiredParacetamol(string Patients = null);      
    Task<IEnumerable<Object>> MedicineExpireBeforeYear(int year);
    Task<IEnumerable<object>> MedicationsThatHaveNotBeenSold(int? year);    
    Task<IEnumerable<object>> MedicineExpireInYear(int year);
}