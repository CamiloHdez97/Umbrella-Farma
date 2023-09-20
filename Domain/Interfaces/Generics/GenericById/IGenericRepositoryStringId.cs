using Domain.Entities;

namespace Domain.Interfaces.Generics.GenericById;
public interface IGenericRepositoryStringId<T>: IGenericRepository<T> where T: BaseEntityIdString{
    Task<T?> GetByIdAsync(string id);
    
}
