using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;

public sealed class MedicineRepository : GenericRepositoryIntId<Medicine>, IMedicineRepository{
    
    private readonly DataContext _context;

    public MedicineRepository(DataContext context) : base(context){
        _context = context;
    } 
    protected override async Task<IEnumerable<Medicine>> GetAll(Expression<Func<Medicine, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Inventory)
                .Include(x => x.State)
                .Include(x => x.Sales)
                .Include(x => x.Shoppings)
                .Include(x => x.SaleDetails)
                .Include(x => x.ShoppingDetails)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Inventory)
            .Include(x => x.State)
            .Include(x => x.Sales)
            .Include(x => x.Shoppings)
            .Include(x => x.SaleDetails)
            .Include(x => x.ShoppingDetails)            
            .ToListAsync();
    }
        public async Task<IEnumerable<object>> ProviderContactMedicine(){
            
            var listPersons = _context.Persons.ToList();
            var listContacts = _context.Contacts.ToList();
            var listContactCategory = _context.ContactCategory.ToList();
            var listContactType = _context.ContactTypes.ToList();
            var listprovider = _context.Suppliers.ToList();
            var listShopping = _context.Shoppings.ToList();
            var listMedicine = _context.Medicines.ToList();
            var listMedicineInfo = _context.MedicineInfos.ToList();

            var query = (
                from person in listPersons
                join provider in listprovider on person.Id equals provider.Id
                join contact in listContacts on person.Id equals contact.PersonId 
                join contactType in listContactType on contact.PersonId equals contactType.Id
                join contactCategory in listContactCategory on contact.PersonId equals contactCategory.Id 
                join shopping in listShopping on provider.Id equals shopping.Id
                join medicine in listMedicine on shopping.Id equals medicine.Id
                join medicineInfo in listMedicineInfo on medicine.Id equals medicineInfo.Id

                //group provider by person into g
                select new {

                        id = provider.Id,
                        Name = person.Name,    
                        contact = contact.Description,
                        typeContact = contactType.Name,
                        categoriesContact = contactCategory.Name,
                        medicineInfo = medicineInfo.Description
                        
                        }
                ).FirstOrDefault();
                return await Task.FromResult(new[] { query });     
        }

}
