using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class CountryRepository : GenericRepositoryIntId<Country>, ICountryRepository{
    public CountryRepository(DataContext context) : base(context){}

    protected override bool PaginateExpression(Country entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<Country>> GetAll(Expression<Func<Country, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Departments)                
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Departments)            
            .ToListAsync();
    }
}