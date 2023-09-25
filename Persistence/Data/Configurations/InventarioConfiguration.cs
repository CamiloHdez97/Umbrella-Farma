using System.IO.Compression;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("inventory");
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Location).HasColumnName("location")
            .HasColumnType("varchar").IsRequired().HasMaxLength(50);

            builder.Property(p => p.TotalStock).HasColumnName("TotalStock")
            .HasColumnType("int").IsRequired().HasMaxLength(3);

            builder.HasOne(e => e.MedicineInfo).WithMany(m => m.Inventories).HasForeignKey(e => e.MedicineInfoId);


            builder.HasData(
                new{
                    Id =1,
                    Location = "A001",
                    TotalStock = 150,
                    MedicineInfoId = 1
                },
                new{
                    Id =2,
                    Location = "A002",
                    TotalStock = 50,
                    MedicineInfoId = 2
                },
                new{
                    Id =3,
                    Location = "C051",
                    TotalStock = 30,
                    MedicineInfoId = 3
                },
                new{
                    Id =4,
                    Location = "D221",
                    TotalStock = 40,
                    MedicineInfoId = 4
                },
                new{
                    Id =5,
                    Location = "Q011",
                    TotalStock = 110,
                    MedicineInfoId = 5
                },
                new{
                    Id =6,
                    Location = "C102",
                    TotalStock = 95,
                    MedicineInfoId = 6
                },
                new{
                    Id =7,
                    Location = "C101",
                    TotalStock = 190,
                    MedicineInfoId = 7
                },
                new{
                    Id =8,
                    Location = "D048",
                    TotalStock = 200,
                    MedicineInfoId = 8
                },
                new{
                    Id =9,
                    Location = "H048",
                    TotalStock = 25,
                    MedicineInfoId = 9
                },
                new{
                    Id =10,
                    Location = "H051",
                    TotalStock = 120,
                    MedicineInfoId = 10
                }
            );
        }
    }

}