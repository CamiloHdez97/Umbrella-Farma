using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class ContactConfiguration : IEntityTypeConfiguration<Contact> {
    public void Configure (EntityTypeBuilder<Contact> builder) {
        builder.ToTable("contact");

        builder.HasKey(x => new{x.PersonId,x.ContactTypeId,x.ContactCategoryId});
        
        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("description")
            .HasMaxLength(100);

        builder.Property(x => x.PersonId)
            .IsRequired()
            .HasColumnName("personId");
        
        builder.Property(x => x.ContactTypeId)
            .IsRequired()
            .HasColumnName("contactTypeId");
        
        builder.Property(x => x.ContactCategoryId)
            .IsRequired()
            .HasColumnName("ContactCategoryId");
        
        builder.HasOne(x => x.Person)
            .WithMany(x => x.Contacts)
            .HasForeignKey(x => x.PersonId);

        builder.HasOne(x => x.ContactType)
            .WithMany(x => x.Contacts)
            .HasForeignKey(x => x.ContactTypeId);
        
        builder.HasOne(x => x.ContactCategory)
            .WithMany(x => x.Contacts)
            .HasForeignKey(x => x.ContactCategoryId);
           
    }
}