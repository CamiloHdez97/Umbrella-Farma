using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class ContactConfiguration : IEntityTypeConfiguration<Contact> {
    public void Configure (EntityTypeBuilder<Contact> builder) {
        builder.ToTable("contact");

        builder.HasKey(x => new{x.PersonId,x.ContactTypeId,x.ContactCategoryId});
        
        //--Properties
        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("description")
            .HasMaxLength(100);

        builder.Property(x => x.PersonId)
            .IsRequired()
            .HasColumnName("personIdFk");
        
        builder.Property(x => x.ContactTypeId)
            .IsRequired()
            .HasColumnName("contactTypeIdFk");
        
        builder.Property(x => x.ContactCategoryId)
            .IsRequired()
            .HasColumnName("ContactCategoryIdFk");
        
        //--Relations 
        builder.HasOne(p => p.Person)
            .WithMany(m => m.Contacts)
            .HasForeignKey(p => p.PersonId);

        builder.HasOne(p => p.ContactType)
            .WithMany(m => m.Contacts)
            .HasForeignKey(p => p.ContactTypeId);
        
        builder.HasOne(p => p.ContactCategory)
            .WithMany(m => m.Contacts)
            .HasForeignKey(p => p.ContactCategoryId);

        builder.HasData(
            new{          
                Description = "contacto@proveedor_a.com",
                PersonId = 2,
                ContactTypeId = 2,
                ContactCategoryId = 1
            },
            new{       
                Description = "contacto@proveedor_b.com",
                PersonId = 3,
                ContactTypeId = 2,
                ContactCategoryId = 1
            },
            new{    
                Description = "contacto@proveedor_c.com",
                PersonId = 4,
                ContactTypeId = 2,
                ContactCategoryId = 1
            }
        );
           
    }
}