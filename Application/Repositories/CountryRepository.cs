using System.Security.Cryptography.X509Certificates;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class CountryRepository : GenericRepositoryIntId<Country>, ICountryRepository{
    public CountryRepository(DataContext context) : base(context){}

    protected override bool PaginateExpression(Country entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}