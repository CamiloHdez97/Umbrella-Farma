using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class DocumentTypeRepository : GenericRepositoryIntId<DocumentType>, IDocumentTypeRepository{
    public DocumentTypeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(DocumentType entity, string search){
        return entity.Description.Trim().StartsWith(search);
    }

    protected override async Task<IEnumerable<DocumentType>> GetAll(Expression<Func<DocumentType, bool>>? expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Person)                                
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Person)                        
            .ToListAsync();
    }
}