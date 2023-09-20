using Domain.Entities;
using Domain.Entities.Generics;
using Persistence;

namespace Application.Repositories.Generics.GenericById;
public abstract class GenericRepositoryStringId<T> : GenericRepository<T> where T : BaseEntityIdString{
    public GenericRepositoryStringId(DataContext context) : base(context){}
    public virtual async Task<T?> GetByIdAsync(string id)=> await _Entities.FindAsync(id);

}