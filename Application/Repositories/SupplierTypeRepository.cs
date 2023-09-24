using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class SupplierTypeRepository : GenericRepositoryIntId<SupplierType>, ISupplierTypeRepository{
    public SupplierTypeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(SupplierType entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<SupplierType>> GetAll(Expression<Func<SupplierType, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Suppliers)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Suppliers)
            .ToListAsync();
    }
}