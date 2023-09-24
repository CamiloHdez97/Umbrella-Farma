using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class EmployeeRepository : GenericRepositoryIntId<Employee>, IEmployeeRepository{
    public EmployeeRepository(DataContext context) : base(context){}
    protected override async Task<IEnumerable<Employee>> GetAll(Expression<Func<Employee, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Person)        
                .Include(x => x.Charge)        
                .Include(x => x.Sales)        
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Person)
            .Include(x => x.Sales)        
            .Include(x => x.Charge)
            .ToListAsync();
    }
}