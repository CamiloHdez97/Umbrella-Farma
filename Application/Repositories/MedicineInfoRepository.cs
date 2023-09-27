using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class MedicineInfoRepository : GenericRepositoryIntId<MedicineInfo>, IMedicineInfoRepository{    
    private readonly DbContext _Context;
    public MedicineInfoRepository(DataContext context) : base(context)
    => _Context = context;

    
    public async Task<IEnumerable<object>> MedicineWithMinStock (int minStock){
        return await (from medicineItem in _Entities
            select new {
                Medicine = new{
                    medicineItem.Id,
                    medicineItem.Name,
                    medicineItem.Price,
                    medicineItem.Discount,
                    medicineItem.Image,
                    medicineItem.RequiredRecipe,
                    MedicineBrand = medicineItem.MedicineBrand.Name,
                    MedicinePresentation = medicineItem.MedicinePresentation.Name,
                    MedicineCategory = medicineItem.MedicineCategory.Name
                },
                TotalStock = _Context.Set<Medicine>().Where(x => x.Inventory.MedicineInfo.Name == medicineItem.Name && x.StateId == 1).Count()
            }).ToListAsync();        
    }
    public async Task<IEnumerable<MedicineDetailTotalModel>> PurchasedBySupplier (string supplierName){
        var data  = await (from detail in _Context.Set<ShoppingDetail>()
                where 
                    detail.Shopping.Supplier.Person.Name.Trim().ToLower() == supplierName.Trim().ToLower()
                select detail.Medicine.Inventory.MedicineInfo           
            ).ToListAsync(); 
        return MovementDetail( data );
    } 
    public async Task<IEnumerable<MedicineDetailTotalModel>> TotalDrugSales(string MedicineName){
        var data  = await (from detail in _Context.Set<SaleDetail>()
                where 
                    detail.Medicine.Inventory.MedicineInfo.Name.Trim().ToLower() == MedicineName.Trim().ToLower()
                select detail.Medicine.Inventory.MedicineInfo           
            ).ToListAsync();            
        return MovementDetail( data );
    }    
    public async Task<IEnumerable<object>> TotalMedicationsSoldByProvider(){
        var medicines = await (
                from detail in _Context.Set<ShoppingDetail>()
                let medicineInfo = detail.Medicine.Inventory.MedicineInfo
                join supplier in _Context.Set<Supplier>() on detail.Shopping.SupplierId equals supplier.Id
                join Person in _Context.Set<Person>() on supplier.PersonId equals Person.Id
                select  new {                                
                    medicineInfo.Name,
                    Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100)),
                    medicineInfo.Description,
                    medicineInfo.Image,
                    Supplier = Person.Name
                }).ToListAsync();
        return from medicine in medicines 
            group medicine by medicine.Supplier into medicineGroup               
            select new {
                medicineGroup.First().Supplier,
                TotalSaled = medicineGroup.Sum(x => x.Price),
                TotalUnits = medicineGroup.Count()
            };
    }
    public async Task<float> MoneyRaisedFromSales(string medicineName = null){

        var medicines =  await (from detail in _Context.Set<SaleDetail>()
            let medicine = detail.Medicine.Inventory.MedicineInfo
            select new {
                medicine.Name,
                Price = medicine.Price - (medicine.Price * (medicine.Discount / 100)),
            }).ToListAsync();
        
        var res = from medicine in medicines
            group medicine by medicine.Name into medicineGroup
            select new {
                medicineGroup.First().Name,
                TotalPrice = medicineGroup.Sum(x => x.Price) * medicineGroup.Count(),                
            };

        if(medicineName!= null){
            return res.Where(x => x.Name == medicineName).Sum(x => x.TotalPrice);
        }
        return res.Sum(x => x.TotalPrice);

    }
    public async Task<IEnumerable<MedicineDetailTotalModel>> MedicationsThatWereNotSold(){
        var medicines = await (
            from medicine in _Context.Set<Medicine>()
            join state in _Context.Set<State>() on medicine.State.Id equals state.Id
            where state.Description == "default"
            let medicineInfo = medicine.Inventory.MedicineInfo
            select new MedicineDetailModel{
                Name = medicineInfo.Name,
                Price = medicineInfo.Price,
                Description = medicineInfo.Description,
                Image = medicineInfo.Image
            }).ToListAsync();
        return from medicine in medicines   
            group medicine by medicine.Name into medicineGroup
            select new MedicineDetailTotalModel{
                Medicine = medicineGroup.First(),
                Total = medicineGroup.Count()
            };
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


    private static IEnumerable<MedicineDetailTotalModel> MovementDetail(IEnumerable<MedicineInfo> data){
        var medicines =(from detail in data             
            select new MedicineDetailModel{                                
                Name = detail?.Name,
                Price = detail.Price - (detail.Price * (detail.Discount / 100)),
                Description = detail?.Description,
                Image = detail?.Image,
            }).ToList();

        return from medicine in medicines
            group medicine by medicine.Name into grouped
            select new MedicineDetailTotalModel{
                Medicine = grouped.First(),
                Total = grouped.Count()
            };
    }    

    
        public async Task<IEnumerable<object>> MedicineExpireYear(int year){

            var listMedicine = _Context.Set<Medicine>();
            var listMedicineInfo = _Context.Set<MedicineInfo>();
            var listInventory = _Context.Set<Inventory>();

            var query = (

                from medicineInfo in listMedicineInfo
                join inventory in listInventory on medicineInfo.Id equals inventory.MedicineInfoId
                join medicine in listMedicine on inventory.Id equals medicine.InventoryId
                where medicine.ExpirationDate.Year > year
                select new {

                    id = medicine.Id,
                    Medicine = medicineInfo.Name,
                    Expiration = medicine.ExpirationDate

                } 
            );

            return await query.ToListAsync();
        }


}