using Domain.Entities.Generics;

namespace Domain.Interfaces.Generics.GenericById;
public interface IGenericRepositoryIntId<T>: IGenericRepository<T> where T: BaseEntityWithIntId{    
    Task<T?> GetByIdAsync(int id);
}
