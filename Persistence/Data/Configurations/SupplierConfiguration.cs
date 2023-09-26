using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>{
    public void Configure(EntityTypeBuilder<Supplier> builder) {
        builder.ToTable("supplier");
        builder.HasKey(p => p.Id);

        //--Properties
        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        //--Relations
        builder.HasOne(p => p.Person)
            .WithMany(m => m.Suppliers)
            .HasForeignKey(p => p.PersonId);

        builder.HasOne(p => p.SupplierType)
            .WithMany(m => m.Suppliers)
            .HasForeignKey(p => p.SupplierTypeId);
        
        builder.HasData(
            new{
                Id = 1,
                PersonId = 2,
                SupplierTypeId = 1
            },
            new{
                Id = 2,
                PersonId = 3,
                SupplierTypeId = 2
            },
            new{
                Id = 3,
                PersonId = 4,
                SupplierTypeId = 3
            }            
        );
    }
}