using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class ContactTypeRepository : GenericRepositoryIntId<ContactType>, IContactTypeRepository{
    public ContactTypeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(ContactType entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}