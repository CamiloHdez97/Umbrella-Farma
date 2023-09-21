using System.Reflection;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class DataContext: DbContext{
    public DataContext(DbContextOptions<DataContext> conf):base(conf){}


    //-Dbsets
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    
    //-Configurations
    protected override void OnModelCreating(ModelBuilder modelBuilder){  
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
