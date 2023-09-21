using Application.Repositories;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;
public sealed class UnitOfWork : IUnitOfWork, IDisposable{
    private readonly DataContext _Context;
    //-Repositories
    private IRoleRepository? _Role;
    private IUserRepository? _User;
    private IAddressRepository? _Address;
    private IChargeRepository? _Charge;
    private ICityRepository? _City;
    private IContactCategoryRepository? _ContactCategory;
    private IContactTypeRepository? _ContactType;
    private ICountryRepository? _Country;
    private IDepartmentRepository? _Department;
    private IDocumentTypeRepository? _DocumentType;
    private IEmployeeRepository? _Employee;
    private IEpsTypeRepository? _EpsType;
    private IInventoryRepository? _Inventory;
    private IMedicineRepository? _Medicine;
    private IMedicineBrandRepository? _MedicineBrand;
    private IMedicineCategoryRepository? _MedicineCategory;
    private IMedicineInfoRepository? _MedicineInfo;
    private IMedicinePresentationRepository? _MedicinePresentation;
    private IPersonRepository? _Person;
    private IRecipeRepository? _Recipe;
    private ISaleRepository? _Sale;
    private IShoppingRepository? _Shopping;
    private IStateRepository? _State;
    private ISupplierTypeRepository? _SupplierType;
    private ITypePersonRepository? _TypePerson;

    public UnitOfWork(DataContext context)=>_Context = context;

    //-Singletons
    public IRoleRepository Roles => _Role ??= _Role = new RoleRepository(_Context);
    public IUserRepository Users => _User ??= _User = new UserRepository(_Context);

    public IAddressRepository Addresses => _Address??= new AddressRepository(_Context);

    public IChargeRepository Charges => _Charge??= new ChargeRepository(_Context);

    public ICityRepository Cities => _City??= new CityRepository(_Context);

    public IContactCategoryRepository ContactCategories => _ContactCategory??= new ContactCategoryRepository(_Context);

    public IContactTypeRepository ContactTypes => _ContactType??= new ContactTypeRepository(_Context);

    public ICountryRepository Countries => _Country??= new CountryRepository(_Context);

    public IDepartmentRepository Departments => _Department??= new DepartmentRepository(_Context);

    public IDocumentTypeRepository DocumentTypes => _DocumentType??= new DocumentTypeRepository(_Context);

    public IEmployeeRepository Employees => _Employee??= new EmployeeRepository(_Context);

    public IEpsTypeRepository EpsTypes => _EpsType??= new EpsTypeRepository(_Context);

    public IInventoryRepository Inventories => _Inventory??= new InventoryRepository(_Context);

    public IMedicineRepository Medicines => _Medicine??= new MedicineRepository(_Context);

    public IMedicineBrandRepository MedicineBrands => _MedicineBrand??= new MedicineBrandRepository(_Context);

    public IMedicineCategoryRepository MedicineCategories => _MedicineCategory??= new MedicineCategoryRepository(_Context);

    public IMedicineInfoRepository MedicineInfos => _MedicineInfo??= new MedicineInfoRepository(_Context);

    public IMedicinePresentationRepository MedicinePresentations => _MedicinePresentation??= new MedicinePresentationRepository(_Context);

    public IPersonRepository Person => _Person??= new PersonRepository(_Context);

    public IRecipeRepository Recipes => _Recipe??= new RecipeRepository(_Context);

    public ISaleRepository Sales => _Sale??= new SaleRepository(_Context);

    public IShoppingRepository Shoppings => _Shopping??= new ShoppingRepository(_Context);

    public IStateRepository States => _State??= new StateRepository(_Context);

    public ISupplierTypeRepository SupplierTypes => _SupplierType??= new SupplierTypeRepository(_Context);

    public ITypePersonRepository TypesPerson => _TypePerson??= new TypePersonRepository(_Context);

    //-Other Properties
    public void Dispose()=> _Context.Dispose();
    public async Task<int> SaveChanges()=> await _Context.SaveChangesAsync();
}
