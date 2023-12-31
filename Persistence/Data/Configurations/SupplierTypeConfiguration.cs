using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class SupplierTypeConfiguration : IEntityTypeConfiguration<SupplierType> {
    public void Configure(EntityTypeBuilder<SupplierType> builder) {
        builder.ToTable("suppliertype");
        builder.HasKey(p => p.Id);

        //--Properties
        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("suppliertypename")
            .HasMaxLength(50);

        builder.HasData(
            new{
                Id=1,
                Name = "Drugs"
            },
            new{
                Id=2,
                Name = "syrups"
            },
            new{
                Id=3,
                Name = "hallucinogens"
            }
        );
    }
}
