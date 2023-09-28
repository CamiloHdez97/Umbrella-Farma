using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;

namespace Domain.Interfaces;
public interface IEmployeeRepository: IGenericRepositoryIntId<Employee>{
      Task<IEnumerable<object>> GetEmployeSale(int year);
}
