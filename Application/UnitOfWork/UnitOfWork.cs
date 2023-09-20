using Application.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;
public sealed class UnitOfWork : IUnitOfWork, IDisposable{
    private readonly DataContext _Context;
    //-Repositories
    private IRoleRepository? _Role;
    private IUserRepository? _User;

    public UnitOfWork(DataContext context)=>_Context = context;

    //-Singletons
    public IRoleRepository Roles => _Role ??= _Role = new RoleRepository(_Context);
    public IUserRepository Users => _User ??= _User = new UserRepository(_Context);

    //-Other Properties
    public void Dispose()=> _Context.Dispose();
    public async Task<int> SaveChanges()=> await _Context.SaveChangesAsync();
}
