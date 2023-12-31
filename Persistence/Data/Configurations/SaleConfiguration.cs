using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    private static readonly Random _random = new();
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
                    t.HasData(GetSaleDetailSeed(102));
                }
            );
        builder.HasData(
            GetSaleSeed()
        );
    }

    private static List<Sale> GetSaleSeed(){
        List<Sale> salesList = new();
        for (int i = 1; i <= 130; i++){
            salesList.Add(new Sale{
                Id = i,
                SaleDate = new DateTime(2023,05,05).AddDays(_random.Next(1,365)),
                EmployeeId = _random.Next(1,4),
                PersonId = _random.Next(5,11)
            });

        }
        return salesList;
            
    }
    private static HashSet<SaleDetail> GetSaleDetailSeed(int recordsNumber){
        HashSet<SaleDetail> SaleDetailsList = new();
        for (int i = 1; i < recordsNumber; i++){
            SaleDetailsList.Add(new SaleDetail{                                    
                MedicineId = i,
                SaleId = _random.Next(1,130)
            });
        }
        return SaleDetailsList;
    }
}