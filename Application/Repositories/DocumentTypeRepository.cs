using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class DocumentTypeRepository : GenericRepositoryIntId<DocumentType>, IDocumentTypeRepository{
    public DocumentTypeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(DocumentType entity, string search){
        return entity.Description.Trim().StartsWith(search);
    }
}