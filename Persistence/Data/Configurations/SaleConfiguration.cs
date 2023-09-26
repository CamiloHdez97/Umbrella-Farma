using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class SaleConfiguration : IEntityTypeConfiguration<Sale>{
    public void Configure(EntityTypeBuilder<Sale> builder){
        builder.ToTable("sale");
        builder.HasKey(p => p.Id);

        //--Properties
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

        //--Relations
        builder.HasOne(p => p.Person)
            .WithMany(m => m.Sales)
            .HasForeignKey(p => p.PersonId);

        builder.HasOne(p => p.Employee)
            .WithMany(m => m.Sales)
            .HasForeignKey(p => p.EmployeeId);
        
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
        builder.HasData(
            new{
                Id = 1,
                SaleDate = new DateTime(2023,01,10),
                EmployeeId = 1,
                PersonId = 5
            },
            new{
                Id = 2,
                SaleDate = new DateTime(2023,01,15),
                EmployeeId = 2,
                PersonId = 7
            },
            new{
                Id = 3,
                SaleDate = new DateTime(2023,02,05),
                EmployeeId = 1,
                PersonId = 3
            },
            new{
                Id = 4,
                SaleDate = new DateTime(2023,02,12),
                EmployeeId = 1,
                PersonId = 11
            },
            new{
                Id = 5,
                SaleDate = new DateTime(2023,02,12),
                EmployeeId = 1,
                PersonId = 11
            },
            new{
                Id = 6,
                SaleDate = new DateTime(2023,03,10),
                EmployeeId = 2,
                PersonId = 5
            },
            new{
                Id = 7,
                SaleDate = new DateTime(2023,03,10),
                EmployeeId = 2,
                PersonId = 5
            },
            new{
                Id = 8,
                SaleDate = new DateTime(2023,04,15),
                EmployeeId = 2,
                PersonId = 7
            },
            new{
                Id = 8,
                SaleDate = new DateTime(2023,04,15),
                EmployeeId = 2,
                PersonId = 7
            },
            new{
                Id = 9,
                SaleDate = new DateTime(2023,05,05),
                EmployeeId = 2,
                PersonId = 7
            }
        );
    }
}