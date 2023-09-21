using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class InventoryRepository : GenericRepositoryIntId<Inventory>, IInventoryRepository{
    public InventoryRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(Inventory entity, string search){
        return entity.Location.Trim().StartsWith(search);
    }
}