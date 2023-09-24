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

        // Relations
    }
}