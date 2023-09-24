using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class SaleRepository : GenericRepositoryIntId<Sale>, ISaleRepository{
    public SaleRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(Sale entity, string search){        
        if(DateTime.TryParse(search,out DateTime searchDate)){
            return entity.SaleDate.Equals(searchDate);
        }
        return true;
    }

    protected override async Task<IEnumerable<Sale>> GetAll(Expression<Func<Sale, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Employee)
                .Include(x => x.Person)
                .Include(x => x.Recipes)
                .Include(x => x.SaleDetails)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Employee)
            .Include(x => x.Person)
            .Include(x => x.Recipes)
            .Include(x => x.SaleDetails)
            .ToListAsync();
    }
}