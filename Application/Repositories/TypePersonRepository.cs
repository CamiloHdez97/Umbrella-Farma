using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class TypePersonRepository : GenericRepositoryIntId<TypePerson>, ITypePersonRepository{
    public TypePersonRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(TypePerson entity, string search){
        return entity.Description.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<TypePerson>> GetAll(Expression<Func<TypePerson, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Person)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Person)
            .ToListAsync();
    }
}