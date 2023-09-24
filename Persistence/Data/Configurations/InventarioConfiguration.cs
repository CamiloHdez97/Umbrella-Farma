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

        }
    }

}