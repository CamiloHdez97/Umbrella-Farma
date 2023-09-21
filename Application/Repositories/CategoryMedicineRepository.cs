using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class MedicineCategoryRepository : GenericRepositoryIntId<MedicineCategory>, IMedicineCategoryRepository{
    public MedicineCategoryRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(MedicineCategory entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}