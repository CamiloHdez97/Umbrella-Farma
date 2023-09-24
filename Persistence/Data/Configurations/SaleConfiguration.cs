using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class SaleConfiguration : IEntityTypeConfiguration<Sale>{
    public void Configure(EntityTypeBuilder<Sale> builder){
        builder.ToTable("sale");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        builder.Property(p => p.SaleDate)
                .HasColumnName("saledate")
                .IsRequired()
                .HasColumnType("DateTime");

        builder.Property(x => x.EmployeeId)
            .IsRequired()
            .HasColumnName("employeeId");
        
        builder.Property(x => x.PersonId)
            .IsRequired()
            .HasColumnName("personId");

        builder.HasOne(x => x.Person)
            .WithMany(x => x.Sales)
            .HasForeignKey(x => x.PersonId);

        builder.HasOne(x => x.Employee)
            .WithMany(x => x.Sales)
            .HasForeignKey(x => x.EmployeeId);
        
        builder.HasMany(p => p.Medicines)
            .WithMany(p => p.Sales)
            .UsingEntity<SaleDetail>(
                t => t.HasOne(j => j.Medicine)
                    .WithMany(j => j.SaleDetails)
                    .HasForeignKey(j => j.MedicineId),
                t => t.HasOne(j => j.Sale)
                    .WithMany(j => j.SaleDetails)
                    .HasForeignKey(j => j.SaleId),
                t => {//--Configurations
                    t.ToTable("saleDetail");
                    t.HasKey(j => new{j.MedicineId,j.SaleId});
        
                    
                }
            );
        
    }
}