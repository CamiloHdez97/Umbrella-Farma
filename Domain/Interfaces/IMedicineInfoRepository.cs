using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;
using Domain.Models;

namespace Domain.Interfaces;
public interface IMedicineInfoRepository: IGenericRepositoryIntId<MedicineInfo>{}