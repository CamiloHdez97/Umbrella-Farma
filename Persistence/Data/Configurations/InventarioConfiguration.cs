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

            builder.HasOne(e => e.MedicineInfo).WithMany(m => m.Inventories).HasForeignKey(e => e.MedicineInfoId);


            builder.HasData(
                new{
                    Id =1,
                    Location = "A001",
                    MedicineInfoId = 1
                },
                new{
                    Id =2,
                    Location = "A002",
                    MedicineInfoId = 2
                },
                new{
                    Id =3,
                    Location = "C051",
                    MedicineInfoId = 3
                },
                new{
                    Id =4,
                    Location = "D221",
                    MedicineInfoId = 4
                },
                new{
                    Id =5,
                    Location = "Q011",
                    MedicineInfoId = 5
                },
                new{
                    Id =6,
                    Location = "C102",
                    MedicineInfoId = 6
                },
                new{
                    Id =7,
                    Location = "C101",
                    MedicineInfoId = 7
                },
                new{
                    Id =8,
                    Location = "D048",
                    MedicineInfoId = 8
                },
                new{
                    Id =9,
                    Location = "H048",
                    MedicineInfoId = 9
                },
                new{
                    Id =10,
                    Location = "H051",
                    MedicineInfoId = 10
                }
            );
        }
    }

}