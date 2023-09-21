using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class RoleRepository : GenericRepositoryIntId<Role>, IRoleRepository{
    public RoleRepository(DataContext context) : base(context){}

    public async Task<Role?> GetRolByRoleName(UserRoles rol)=> await FindFirst(x => x.Description == rol.ToString());

    public async Task<Role?> GetRolByRoleName(string rol) => await FindFirst(x => x.Description == rol);
    protected override bool PaginateExpression(Role entity, string search){
        return entity.Description.Trim().StartsWith(search);
    }

    protected override async Task<IEnumerable<Role>> GetAll(Expression<Func<Role, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Users)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Users)
            .ToListAsync();
    }
    
}