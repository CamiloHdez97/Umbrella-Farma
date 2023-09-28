using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class ShoppingRepository : GenericRepositoryIntId<Shopping>, IShoppingRepository{
    public ShoppingRepository(DataContext context) : base(context){}
    protected override async Task<IEnumerable<Shopping>> GetAll(Expression<Func<Shopping, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Supplier)
                .Include(x => x.Employee)
                .Include(x => x.Medicines)
                .Include(x => x.ShoppingDetails)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Supplier)
            .Include(x => x.Employee)
            .Include(x => x.Medicines)
            .Include(x => x.ShoppingDetails)
            .ToListAsync();
    }

        public async Task<IEnumerable<object>> NoSalesSupplier(int year){

        var listPersons = _context.Set<Person>();
        var listSuppliers = _context.Set<Supplier>();
        var listShoppings = _context.Set<Shopping>();

        var query = (
            from person in listPersons
            join supplier in listSuppliers on person.Id equals supplier.PersonId
            join shopping in listShoppings on supplier.Id equals shopping.SupplierId
            where shopping == null || shopping.ShoppingDate.Year < year
            select new {

                id = person.Id,
                Responsable = person.Name,
                UltimaCompra = shopping.ShoppingDate
                          
            });
            
            var uniqueSupplier = query.GroupBy(item => new {item.id, item.Responsable}).Select(g => g.First());

            return await uniqueSupplier.ToListAsync();

    }
}
