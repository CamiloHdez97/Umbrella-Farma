using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class ContactCategoryRepository : GenericRepositoryIntId<ContactCategory>, IContactCategoryRepository{
    public ContactCategoryRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(ContactCategory entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<ContactCategory>> GetAll(Expression<Func<ContactCategory, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Contacts)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Contacts)
            .ToListAsync();
    }
}