using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class PersonRepository : GenericRepositoryIntId<Person>, IPersonRepository{
    public PersonRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(Person entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<Person>> GetAll(Expression<Func<Person, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.PersonEps)
                .Include(x => x.User)
                .Include(x => x.Employees)
                .Include(x => x.DocumentType)
                .Include(x => x.TypePerson)
                .Include(x => x.Sales)
                .Include(x => x.Suppliers)
                .Include(x => x.Contacts)
                .Include(x => x.ContactType)
                .Include(x => x.ContactCategory)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.PersonEps)
            .Include(x => x.User)
            .Include(x => x.Employees)
            .Include(x => x.DocumentType)
            .Include(x => x.TypePerson)
            .Include(x => x.Sales)
            .Include(x => x.Suppliers)
            .Include(x => x.Contacts)
            .Include(x => x.ContactType)
            .Include(x => x.ContactCategory)           
            .ToListAsync();
    }
}