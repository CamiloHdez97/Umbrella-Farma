using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class MedicineBrandRepository : GenericRepositoryIntId<MedicineBrand>, IMedicineBrandRepository{
    public MedicineBrandRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(MedicineBrand entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}