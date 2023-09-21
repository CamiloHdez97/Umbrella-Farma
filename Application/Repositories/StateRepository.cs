using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class StateRepository : GenericRepositoryIntId<State>, IStateRepository{
    public StateRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(State entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}