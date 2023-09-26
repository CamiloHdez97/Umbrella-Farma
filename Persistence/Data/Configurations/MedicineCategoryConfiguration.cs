using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class MedicineCategoryConfiguration : IEntityTypeConfiguration<MedicineCategory>
    {
        public void Configure(EntityTypeBuilder<MedicineCategory> builder)
        {
            builder.ToTable("medicine_category");

            //--Properties
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Name)
                .HasColumnName("name")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(50);

            builder.HasData(
                new{
                    Id = 1,
                    Name = "Legal"
                },
                new{
                    Id = 2,
                    Name = "Illegal"
                }
            );
            
        }
    }

}