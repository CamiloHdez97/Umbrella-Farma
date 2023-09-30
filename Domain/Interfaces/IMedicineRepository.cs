using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;

namespace Domain.Interfaces;
public interface IMedicineRepository: IGenericRepositoryIntId<Medicine>{
    
    Task<IEnumerable<Object>> ProviderContactMedicine();
    Task<IEnumerable<object>> ListMedicines();
}