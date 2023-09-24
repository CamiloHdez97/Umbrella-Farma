using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class ContactConfiguration : IEntityTypeConfiguration<Contact> {
    public void Configure (EntityTypeBuilder<Contact> builder) {
        builder.ToTable("contact");
        
        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("description")
            .HasMaxLength(100);

        // Relations
    }
}