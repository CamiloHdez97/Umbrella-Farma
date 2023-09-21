using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class PersonRepository : GenericRepositoryIntId<Person>, IPersonRepository{
    public PersonRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(Person entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}