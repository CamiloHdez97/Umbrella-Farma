using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class MedicineInfoRepository : GenericRepositoryIntId<MedicineInfo>, IMedicineInfoRepository{
    public MedicineInfoRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(MedicineInfo entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}