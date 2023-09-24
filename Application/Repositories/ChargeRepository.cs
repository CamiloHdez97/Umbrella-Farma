using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class ChargeRepository : GenericRepositoryIntId<Charge>, IChargeRepository{
    public ChargeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(Charge entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }

    protected override async Task<IEnumerable<Charge>> GetAll(Expression<Func<Charge, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Employees)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Employees)
            .ToListAsync();
    }
}