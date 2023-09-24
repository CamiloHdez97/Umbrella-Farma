using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class ShoppingConfiguration : IEntityTypeConfiguration<Shopping>{
    public void Configure(EntityTypeBuilder<Shopping> builder){
        builder.ToTable("shopping");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");
        
        builder.Property(p => p.ShoppingDate)
                .HasColumnName("shoppingDate")
                .IsRequired()
                .HasColumnType("DateTime");

        builder.Property(x => x.EmployeeId)
            .IsRequired()
            .HasColumnName("employeeId");
        
        builder.Property(x => x.SupplierId)
            .IsRequired()
            .HasColumnName("supplierId");

        builder.HasOne(x => x.Employee)
            .WithMany(x => x.Shoppings)
            .HasForeignKey(x => x.EmployeeId);

        builder.HasOne(x => x.Supplier)
            .WithMany(x => x.Shoppings)
            .HasForeignKey(x => x.SupplierId);
        
        builder.HasMany(p => p.Medicines)
            .WithMany(p => p.Shoppings)
            .UsingEntity<ShoppingDetail>(
                t => t.HasOne(j => j.Medicine)
                    .WithMany(j => j.ShoppingDetails)
                    .HasForeignKey(j => j.MedicineId),
                t => t.HasOne(j => j.Shopping)
                    .WithMany(j => j.ShoppingDetails)
                    .HasForeignKey(j => j.ShoppingId),
                t => {//--Configurations
                    t.ToTable("shoppingDetail");
                    t.HasKey(j => new{j.MedicineId,j.ShoppingId});
        
                    
                }
            );
    }
}