using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;

namespace Domain.Interfaces;
public interface IShoppingRepository: IGenericRepositoryIntId<Shopping>{
  Task<IEnumerable<Object>> NoSalesSupplier(int year);
}
