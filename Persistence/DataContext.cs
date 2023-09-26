using System.Reflection;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class DataContext: DbContext{
    public DataContext(DbContextOptions<DataContext> conf):base(conf){}


    //-Dbsets
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Charge> Charges { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<ContactCategory> ContactCategory { get; set; }
    public DbSet<ContactType> ContactTypes { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public ICollection<EpsEmployee> EpsEmployees {get; set;}
    public DbSet<EpsType> EpsTypes { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<MedicineBrand> MedicineBrands { get; set; }
    public DbSet<MedicineCategory> MedicineCategories { get; set; }
    public DbSet<MedicineInfo> MedicineInfos { get; set; }
    public DbSet<MedicinePresentation> MedicinePresentations { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<PersonType> PersonTypes { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Shopping> Shoppings { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<SupplierType> SupplierTypes { get; set; }
    public DbSet<User> Users { get; set; }
    
    //-Configurations
    protected override void OnModelCreating(ModelBuilder modelBuilder){  
        base.OnModelCreating(modelBuilder);
        Random _random = new();
                Console.WriteLine("fdjgklfdjgkdfjkl!!!!!\n\n");

        /* 
        modelBuilder.Entity<ShoppingDetail>().HasData(
            ()=>{
                
                List<ShoppingDetail> ShoppingDetailsList = new();
                for (int i = 0; i < 100; i++){
                    ShoppingDetailsList.Add(new ShoppingDetail{
                        MedicineId = _random.Next(i+100,100),
                        ShoppingId = _random.Next(1,16)
                    });
                }
                return ShoppingDetailsList;
            }
        ); */

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        
    }
}
