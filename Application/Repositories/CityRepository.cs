using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class CityRepository : GenericRepositoryIntId<City>, ICityRepository{
    public CityRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(City entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}