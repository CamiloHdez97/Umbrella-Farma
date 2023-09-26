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
                PersonId = 2,
                SupplierTypeId = 1
            },
            new{
                PersonId = 3,
                SupplierTypeId = 2
            },
            new{
                PersonId = 4,
                SupplierTypeId = 3
            }            
        );
    }
}