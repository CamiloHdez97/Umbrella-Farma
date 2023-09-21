using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class MedicinePresentationRepository : GenericRepositoryIntId<MedicinePresentation>, IMedicinePresentationRepository{
    public MedicinePresentationRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(MedicinePresentation entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}