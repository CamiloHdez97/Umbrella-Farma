using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Application.Models;

namespace Application.Repositories;
public sealed class MedicineInfoRepository : GenericRepositoryIntId<MedicineInfo>, IMedicineInfoRepository{
    private readonly DbSet<Medicine> _Medicines;
    public MedicineInfoRepository(DataContext context) : base(context){
        _Medicines = context.Medicines;
    }

    public async Task<IEnumerable<MedicineInfoWithStockModel>> MedicineWithMinStock (int minStock){
        IEnumerable<MedicineInfoWithStockModel> medicines = await(
        (from medicineItem in  _Entities                      
            select new MedicineInfoWithStockModel{
                Name = medicineItem.Name,
                Price = medicineItem.Price,
                Discount = medicineItem.Discount,
                Image = medicineItem.Image,
                RequiredRecipe = medicineItem.RequiredRecipe,
                MedicineBrand = medicineItem.MedicineBrand.Name,
                MedicinePresentation = medicineItem.MedicinePresentation.Name,
                MedicineCategory = medicineItem.MedicineCategory.Name,
                TotalStok = _Medicines.Where(x => x.Inventory.MedicineInfoId == medicineItem.Id && x.StateId == 1).Count()            
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