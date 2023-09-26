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
            
            builder.HasOne(e => e.State).WithMany(p => p.Medicines).HasForeignKey(p => p.StateId);

            builder.HasData(MedicineGenerator(200));

        }      

        private List<Medicine> MedicineGenerator(int NumberOfMedicines){
            var data = new List<Medicine>();
            Random random = new();
            for (int i = 0; i < NumberOfMedicines; i++){
                var medicine = new Medicine{
                    Id = i + 1,
                    CreationDate = new DateTime(2023,03,2).AddDays(random.Next(1,365)),
                    ExpirationDate = new DateTime(2025,12,2).AddDays(random.Next(1,365)),
                    InventoryId = random.Next(1,10),
                    StateId = random.Next(1,5)
                };      
                data.Add(medicine);
            }
            return data;

        }
}