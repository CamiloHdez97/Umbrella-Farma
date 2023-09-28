using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

    public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder.ToTable("medicine");

            //--Properties
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired();
    
            builder.Property(p => p.CreationDate)
                .HasColumnName("creation_date")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.ExpirationDate)
                .HasColumnName("expiration_date")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.InventoryId)
                .IsRequired()
                .HasColumnName("inventoryIdFk");

            builder.Property(p => p.StateId)
                .IsRequired()
                .HasColumnName("stateIdFk");
            
            //--Relations
            builder.HasOne(p => p.State)
                .WithMany(m => m.Medicines)
                .HasForeignKey(p => p.StateId);

            builder.HasOne(p => p.Inventory)
                .WithMany(m => m.Medicines)
                .HasForeignKey(p => p.InventoryId);


            builder.HasData(MedicineGenerator(500));
        }      

        private static List<Medicine> MedicineGenerator(int NumberOfMedicines){
            var data = new List<Medicine>();
            Random random = new();
            for (int i = 1; i < NumberOfMedicines; i++){
                int stateId = 1;
                if(i <= 102){stateId = 4;}

                int hasAddDays = random.Next(0, 365) < 30 ? -1 : 1;            

                var  CreationDate = DateTime.Now.AddDays(-1 * random.Next(1,365)).AddMonths(-1 * random.Next(0,
                12));

                var ExpirationDate = DateTime.Now.AddDays(hasAddDays * random.Next(1,365)).AddMonths(hasAddDays * random.Next(0,12));

                if(random.Next(1,500) < 70){stateId = 3;}
                if(ExpirationDate<DateTime.Now){stateId = 2;}

                var medicine = new Medicine{
                    Id = i ,
                    CreationDate =CreationDate,
                    ExpirationDate =ExpirationDate ,
                    InventoryId = random.Next(1,10),
                    StateId = stateId
                };      
                data.Add(medicine);
            }
            return data;
        }
}