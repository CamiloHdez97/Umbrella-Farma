namespace Domain.Interfaces;
public interface IUnitOfWork{
    IAddressRepository Addresses { get; }
    IChargeRepository Charges { get; }
    ICityRepository Cities { get; }
    IContactCategoryRepository ContactCategories { get; }
    IContactTypeRepository ContactTypes { get; }
    ICountryRepository Countries { get; }
    IDepartmentRepository Departments { get; }
    IDocumentTypeRepository DocumentTypes { get; }
    IEmployeeRepository Employees { get; }
    IEpsTypeRepository EpsTypes { get; }
    IInventoryRepository Inventories { get; }    
    IMedicineRepository Medicines { get; }    
    IMedicineBrandRepository MedicineBrands { get; }
    IMedicineCategoryRepository MedicineCategories { get; }
    IMedicineInfoRepository MedicineInfos { get; }
    IMedicinePresentationRepository MedicinePresentations { get; }
    IPersonRepository Person { get; }
    IRecipeRepository Recipes { get; }
    IRoleRepository Roles { get; }    
    ISaleRepository Sales { get; }
    IShoppingRepository Shoppings { get; }
    IStateRepository States { get; }
    ISupplierTypeRepository SupplierTypes { get; }
    ITypePersonRepository TypesPerson { get; }
    IUserRepository Users { get; }   

    Task<int> SaveChanges();
}
