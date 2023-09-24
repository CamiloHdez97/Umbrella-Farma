using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class InventoryRepository : GenericRepositoryIntId<Inventory>, IInventoryRepository{
    public InventoryRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(Inventory entity, string search){
        return entity.Location.Trim().StartsWith(search);
    }

    protected override async Task<IEnumerable<Inventory>> GetAll(Expression<Func<Inventory, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.MedicineInfo)
                .Include(x => x.Medicines)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.MedicineInfo)            
            .Include(x => x.Medicines)
            .ToListAsync();
    }
}