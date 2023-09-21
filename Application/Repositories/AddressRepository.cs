using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class AddressRepository : GenericRepositoryIntId<Address>, IAddressRepository{
    public AddressRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(Address entity, string search){
        return entity.Description.Trim().StartsWith(search);
    }
}