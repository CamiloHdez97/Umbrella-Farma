using Domain.Entities;

namespace Domain.Interfaces.Generics.GenericById;
public interface IGenericRepositoryStringId<T>: IGenericRepository<T> where T: BaseEntityWithStringId{
    Task<T?> GetByIdAsync(string id);
    
}
