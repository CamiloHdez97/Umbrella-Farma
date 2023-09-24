using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class CityRepository : GenericRepositoryIntId<City>, ICityRepository{
    public CityRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(City entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<City>> GetAll(Expression<Func<City, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Department)
                .Include(x => x.Addresses)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Department)
            .Include(x => x.Addresses)
            .ToListAsync();
    }
}