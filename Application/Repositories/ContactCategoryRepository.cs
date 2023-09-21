using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class ContactCategoryRepository : GenericRepositoryIntId<ContactCategory>, IContactCategoryRepository{
    public ContactCategoryRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(ContactCategory entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}