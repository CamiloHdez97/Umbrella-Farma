using Domain.Entities;

namespace Domain.Interfaces;
public interface IUnitOfWork{
    IRoleRepository Roles { get; }    
    IUserRepository Users { get; }   

    Task<int> SaveChanges();
}
