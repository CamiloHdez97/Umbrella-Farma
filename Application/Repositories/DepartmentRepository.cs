using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class DepartamentRepository : GenericRepositoryIntId<Departament>, IDepartmentRepository{
    public DepartamentRepository(DataContext context) : base(context){}

    protected override bool PaginateExpression(Departament entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }

    protected override async Task<IEnumerable<Departament>> GetAll(Expression<Func<Departament, bool>> expression = null)
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