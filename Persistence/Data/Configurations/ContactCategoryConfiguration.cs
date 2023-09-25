using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class ContactCategoryConfiguration : IEntityTypeConfiguration<ContactCategory> {
    public void Configure(EntityTypeBuilder<ContactCategory> builder) {
        builder.ToTable("contactCategory");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("contactcategoryname")
            .HasMaxLength(50);

        builder.HasData(
            new{
                Id=1,
                Name = "Email"
            },
            new{
                Id=2,
                Name = "Phone"
            },
            new{
                Id=3,
                Name = "telepathic"
            }
        );
    }
}