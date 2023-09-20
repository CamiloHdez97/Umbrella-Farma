using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;

namespace Domain.Interfaces;
public interface IUserRepository: IGenericRepositoryIntId<User>{
    Task<User?> GetUserByName(string name);
}