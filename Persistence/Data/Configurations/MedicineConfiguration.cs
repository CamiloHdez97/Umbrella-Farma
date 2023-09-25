using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

    public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder){
            
            builder.ToTable("medicine");
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired();
    
            builder.Property(p => p.CreationDate).HasColumnName("creation_date")
            .HasColumnType("date").IsRequired();
            builder.Property(p => p.ExpirationDate).HasColumnName("expiration_date")
            .HasColumnType("date").IsRequired();

            builder.HasOne(e => e.MedicineInfo).WithMany(p => p.Medicines).HasForeignKey(p => p.id_medicine_info);
            builder.HasOne(e => e.State).WithMany(p => p.Medicines).HasForeignKey(p => p.StateId);

        }

}