using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class MedicineBrandConfiguration : IEntityTypeConfiguration<MedicineBrand>
    {
        public void Configure(EntityTypeBuilder<MedicineBrand> builder)
        {
            builder.ToTable("medicine_brand");

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
                .HasMaxLength(30);

            builder.HasData(
                new{
                    Id=1,
                    Name = "TQ"
                },
                new{
                    Id=2,
                    Name = "MK"
                },
                new{
                    Id=3,
                    Name = "La Sante"
                },
                new{
                    Id=4,
                    Name = "Durafex"
                },
                new{
                    Id=5,
                    Name = "Ferrer"
                },
                new{
                    Id=6,
                    Name = "Bayer"
                },
                new{
                    Id=7,
                    Name = "Genfar"
                }
            );
        }
    }

}