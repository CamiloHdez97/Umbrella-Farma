using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class UserRepository : GenericRepositoryIntId<User>, IUserRepository{
    public UserRepository(DataContext context) : base(context){}

    public async Task<User?> GetUserByName(string name)=> await FindFirst(x => x.Name == name);

    public override async Task<User?> FindFirst(Expression<Func<User, bool>> expression)
    =>await _Entities.Include(x => x.Role).Where(expression).FirstOrDefaultAsync();

}