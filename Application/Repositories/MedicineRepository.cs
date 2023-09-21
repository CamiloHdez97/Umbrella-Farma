using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class MedicineRepository : GenericRepositoryIntId<Medicine>, IMedicineRepository{
    public MedicineRepository(DataContext context) : base(context){}
    protected override async Task<IEnumerable<Medicine>> GetAll(Expression<Func<Medicine, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Inventory)
                .Include(x => x.State)
                .Include(x => x.SaleDetail)
                .Include(x => x.ShoppingDetail)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Inventory)
            .Include(x => x.State)
            .Include(x => x.SaleDetail)
            .Include(x => x.ShoppingDetail)            
            .ToListAsync();
    }
}