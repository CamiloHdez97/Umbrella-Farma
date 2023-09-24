using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class ContactTypeConfiguration : IEntityTypeConfiguration<ContactType> {
    public void Configure(EntityTypeBuilder<ContactType> builder) {
        builder.ToTable("contacttype");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("contacttypename")
            .HasMaxLength(50);

        // Relations
    }
}