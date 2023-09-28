using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;

namespace Domain.Interfaces;
public interface ISaleRepository: IGenericRepositoryIntId<Sale>{
    Task<object> VipBuyer();

}