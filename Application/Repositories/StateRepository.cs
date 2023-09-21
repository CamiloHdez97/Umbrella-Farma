using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class StateRepository : GenericRepositoryIntId<State>, IStateRepository{
    public StateRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(State entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<State>> GetAll(Expression<Func<State, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Medicines)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Medicines)
            .ToListAsync();
    }
}