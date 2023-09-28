using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class EmployeeRepository : GenericRepositoryIntId<Employee>, IEmployeeRepository{
    public EmployeeRepository(DataContext context) : base(context){}
    protected override async Task<IEnumerable<Employee>> GetAll(Expression<Func<Employee, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Person)        
                .Include(x => x.Charge)        
                .Include(x => x.Sales)        
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Person)
            .Include(x => x.Sales)        
            .Include(x => x.Charge)
            .ToListAsync();
    }

        public async Task<IEnumerable<object>> GetEmployeSale(int year){

        var listPerson = _context.Set<Person>();
        var listEmployee = _context.Set<Employee>();
        var listSales = _context.Set<Sale>();

        var query = (
            from person in listPerson
            join employee in listEmployee on person.Id equals employee.PersonId
            join sale in listSales on employee.Id equals sale.EmployeeId
            where sale.SaleDate.Year == year
            group sale by new {
                                CodEmpleado = employee.Id,
                                Empleado = person.Name,
                                year

                                } into g

            select new {

                Empleado = g.Key,
                Sales = g.Count(),

            }

        );

        return await query.ToListAsync();

    }
}
