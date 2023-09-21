using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class ChargeRepository : GenericRepositoryIntId<Charge>, IChargeRepository{
    public ChargeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(Charge entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}