using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class AddressRepository : GenericRepositoryIntId<Address>, IAddressRepository{
    public AddressRepository(DataContext context) : base(context){}
    protected override async Task<IEnumerable<Address>> GetAll(Expression<Func<Address, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Person)
                .Include(x => x.City)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Person)
            .Include(x => x.City)
            .ToListAsync();
    }
    protected override bool PaginateExpression(Address entity, string search){
        return entity.Description.Trim().StartsWith(search);
    }
} 