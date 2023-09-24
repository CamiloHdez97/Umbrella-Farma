using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class ShoppingRepository : GenericRepositoryIntId<Shopping>, IShoppingRepository{
    public ShoppingRepository(DataContext context) : base(context){}
    protected override async Task<IEnumerable<Shopping>> GetAll(Expression<Func<Shopping, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Supplier)
                .Include(x => x.Employee)
                .Include(x => x.Medicines)
                .Include(x => x.ShoppingDetails)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Supplier)
            .Include(x => x.Employee)
            .Include(x => x.Medicines)
            .Include(x => x.ShoppingDetails)
            .ToListAsync();
    }
}