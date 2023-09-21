using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class EpsTypeRepository : GenericRepositoryIntId<EpsType>, IEpsTypeRepository{
    public EpsTypeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(EpsType entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<EpsType>> GetAll(Expression<Func<EpsType, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Eps)       
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Eps)            
            .ToListAsync();
    }
}