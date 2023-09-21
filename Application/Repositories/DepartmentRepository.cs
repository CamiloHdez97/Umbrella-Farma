using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class DepartmentRepository : GenericRepositoryIntId<Department>, IDepartmentRepository{
    public DepartmentRepository(DataContext context) : base(context){}

    protected override bool PaginateExpression(Department entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }

    protected override async Task<IEnumerable<Department>> GetAll(Expression<Func<Department, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Country)                
                .Include(x => x.Cities)                
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Country)            
            .Include(x => x.Cities)                
            .ToListAsync();
    }
}