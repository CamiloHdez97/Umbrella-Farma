using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class TypePersonRepository : GenericRepositoryIntId<TypePerson>, ITypePersonRepository{
    public TypePersonRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(TypePerson entity, string search){
        return entity.Description.Trim().StartsWith(search);
    }
}