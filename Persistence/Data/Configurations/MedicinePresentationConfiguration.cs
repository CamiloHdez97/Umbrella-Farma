using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class MedicinePresentationConfiguration : IEntityTypeConfiguration<MedicinePresentation>
    {
        public void Configure(EntityTypeBuilder<MedicinePresentation> builder)
        {
            builder.ToTable("medicine_presentation");
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Name).HasColumnName("name")
            .HasColumnType("varchar").IsRequired().HasMaxLength(50);

            builder.HasData(
                new{
                    Id = 1,
                    Name = "tablets"
                },
                new{
                    Id = 2,
                    Name = "syrups"
                },
                new{
                    Id = 3,
                    Name = "capsule"
                }
            );
        }
    }

}