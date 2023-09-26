using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Linq;
using System.IO.Compression;

namespace Application.Repositories;
public sealed class MedicineInfoRepository : GenericRepositoryIntId<MedicineInfo>, IMedicineInfoRepository{
    private readonly DbSet<Medicine> _Medicines;
    public MedicineInfoRepository(DataContext context) : base(context){
        _Medicines = context.Medicines;
    }

    public async Task<IEnumerable<object>> MedicineWithMinStock (int minStock){
        IEnumerable<object> medicines = await(
        (from medicineItem in  _Entities                      
            select new {
                medicineItem.Name,
                medicineItem.Price,
                medicineItem.Discount,
                medicineItem.Image,
                medicineItem.RequiredRecipe,
                MedicineBrand = medicineItem.MedicineBrand.Name,
                MedicinePresentation = medicineItem.MedicinePresentation.Name,
                MedicineCategory = medicineItem.MedicineCategory.Name,
                TotalStok = _Medicines.Where(x => x.Inventory.MedicineInfoId == medicineItem.Id).Count()            
        }).Where(x => x.TotalStok >= minStock).ToListAsync());
        return medicines;
    }

    protected override bool PaginateExpression(MedicineInfo entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<MedicineInfo>> GetAll(Expression<Func<MedicineInfo, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.MedicineBrand)
                .Include(x => x.MedicinePresentation)
                .Include(x => x.MedicineCategory)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.MedicinePresentation)
            .Include(x => x.MedicineCategory)
            .Include(x => x.MedicineBrand)            
            .ToListAsync();
    }
}