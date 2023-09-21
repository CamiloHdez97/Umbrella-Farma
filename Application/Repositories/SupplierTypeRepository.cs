using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class SupplierTypeRepository : GenericRepositoryIntId<SupplierType>, ISupplierTypeRepository{
    public SupplierTypeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(SupplierType entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}