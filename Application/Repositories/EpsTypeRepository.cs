using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class EpsTypeRepository : GenericRepositoryIntId<EpsType>, IEpsTypeRepository{
    public EpsTypeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(EpsType entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}