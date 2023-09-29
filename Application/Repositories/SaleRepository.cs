using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class SaleRepository : GenericRepositoryIntId<Sale>, ISaleRepository{
    private readonly DataContext _Context;
    public SaleRepository(DataContext context) : base(context){
        _Context = context;
    }
    protected override bool PaginateExpression(Sale entity, string search){        
        if(DateTime.TryParse(search,out DateTime searchDate)){
            return entity.SaleDate.Equals(searchDate);
        }
        return true;
    }

    protected override async Task<IEnumerable<Sale>> GetAll(Expression<Func<Sale, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Employee)
                .Include(x => x.Person)
                .Include(x => x.Recipes)
                .Include(x => x.SaleDetails)
                .Include(x => x.Medicines)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Employee)
            .Include(x => x.Person)
            .Include(x => x.Recipes)
            .Include(x => x.SaleDetails)
            .Include(x => x.Medicines)
            .ToListAsync();
    }

    public async Task<object> VipBuyer(){

        var query = await (from person in _Context.Set<Person>()
            join sale in _Context.Set<Sale>() on person.Id equals sale.PersonId
            join saleDetail in _Context.Set<SaleDetail>() on sale.Id equals saleDetail.SaleId
            join medicine in _Context.Set<Medicine>() on saleDetail.MedicineId equals medicine.Id
            join inventory in _Context.Set<Inventory>() on medicine.Id equals inventory.MedicineInfoId
            join medicineInfo in _Context.Set<MedicineInfo>() on inventory.MedicineInfoId equals medicineInfo.Id
            group medicineInfo.Price by new { person.Id, person.Name } into g
            orderby g.Sum() descending
            select new
            {
                IdPk = g.Key.Id,
                g.Key.Name,
                TotalPrice = g.Sum()
            }).ToListAsync();

        return query.FirstOrDefault();
    }


        public async Task<IEnumerable<object>> AllSaleCustomer(int year){

        var query = await (from person in _Context.Set<Person>()
            join sale in _Context.Set<Sale>() on person.Id equals sale.PersonId
            join saleDetail in _Context.Set<SaleDetail>() on sale.Id equals saleDetail.SaleId
            join medicine in _Context.Set<Medicine>() on saleDetail.MedicineId equals medicine.Id
            join inventory in _Context.Set<Inventory>() on medicine.Id equals inventory.MedicineInfoId
            join medicineInfo in _Context.Set<MedicineInfo>() on inventory.MedicineInfoId equals medicineInfo.Id
            where sale.SaleDate.Year == year
            group medicineInfo.Price by new { person.Id, person.Name, sale.SaleDate } into g
            orderby g.Sum() descending
            select new
            {
                Id = g.Key.Id,
                g.Key.Name,
                YearSales = g.Key.SaleDate,
                TotalPrice = g.Sum()

            }).ToListAsync();

            return query;
        }

    

        public async Task<object> GetSaleParacetamol(string medicineInput, int year)
        {
            string capitalizedMedicineInput = char.ToUpper(medicineInput[0]) + medicineInput.Substring(1);
            var query = (
                            from person in _Context.Set<Person>()
                            join sale in _Context.Set<Sale>() on person.Id equals sale.PersonId
                            join saleDetail in _Context.Set<SaleDetail>() on sale.Id equals saleDetail.SaleId
                            join medicine in _Context.Set<Medicine>() on saleDetail.MedicineId equals medicine.Id
                            join inventory in _Context.Set<Inventory>() on medicine.Id equals inventory.MedicineInfoId
                            join medicineInfo in _Context.Set<MedicineInfo>() on inventory.MedicineInfoId equals medicineInfo.Id
                            where medicineInfo.Name == medicineInput && sale.SaleDate.Year == year
                                                    select new
                                                    {
                                                        PersonId = person.Id,
                                                        person.Name,
                                                        MedicineName = medicineInfo.Name,
                                                        Price = medicineInfo.Price,
                                                        DateSale = sale.SaleDate
                                                    }).ToListAsync();

            return await query;
        }

}