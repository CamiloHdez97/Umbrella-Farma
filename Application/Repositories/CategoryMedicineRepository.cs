using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class MedicineCategoryRepository : GenericRepositoryIntId<MedicineCategory>, IMedicineCategoryRepository{
    public MedicineCategoryRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(MedicineCategory entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<MedicineCategory>> GetAll(Expression<Func<MedicineCategory, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.MedicineInfos)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.MedicineInfos)
            .ToListAsync();
    }
}