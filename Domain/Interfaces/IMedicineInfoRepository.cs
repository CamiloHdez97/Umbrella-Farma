using Application.Models;
using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;

namespace Domain.Interfaces;
public interface IMedicineInfoRepository: IGenericRepositoryIntId<MedicineInfo>{
    Task<IEnumerable<Object>> MedicineWithMinStock();
}