using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class ContactTypeRepository : GenericRepositoryIntId<ContactType>, IContactTypeRepository{
    public ContactTypeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(ContactType entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<ContactType>> GetAll(Expression<Func<ContactType, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Person)
                .Include(x => x.Contacts)
                .Include(x => x.ContactCategory)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Person)
            .Include(x => x.Contacts)
            .Include(x => x.ContactCategory)
            .ToListAsync();
    }
}