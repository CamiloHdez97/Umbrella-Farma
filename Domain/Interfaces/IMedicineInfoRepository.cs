using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;
using Domain.Models;

namespace Domain.Interfaces;
public interface IMedicineInfoRepository: IGenericRepositoryIntId<MedicineInfo>{
    Task<IEnumerable<object>> MedicineWithMinStock(int minStock);
    Task<IEnumerable<MedicineDetailTotalModel>> PurchasedBySupplier (string supplierName);
    Task<IEnumerable<MedicineDetailTotalModel>> TotalDrugSales(string MedicineName);
    Task<IEnumerable<object>> TotalMedicationsSoldByProvider();
    Task<float> MoneyRaisedFromSales(string medicineName = null);
    Task<IEnumerable<MedicineDetailTotalModel>> MedicationsThatWereNotSold();    
}