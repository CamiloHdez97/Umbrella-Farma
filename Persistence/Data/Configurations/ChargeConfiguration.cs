using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class ChargeConfiguration : IEntityTypeConfiguration<Charge> {
    public void Configure(EntityTypeBuilder<Charge> builder) {
        builder.ToTable("charge");
        builder.HasKey(p => p.Id);

        //--Properties
        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("chargeName")
            .HasMaxLength(50);

        builder.HasData(
            new{
                Id=1,
                Name = "seller"
            },
            new{
                Id=2,
                Name = "manager"
            },
            new{
                Id=3,
                Name = "Administrator"
            }
        );
        
    }
}
