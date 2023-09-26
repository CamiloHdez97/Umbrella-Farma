using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("city");

            //--Properties
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_city")
                .HasColumnType("int")
                .IsRequired();
    
            builder.Property(p => p.Name)
                .HasColumnName("name")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(60);
            
            builder.Property(p => p.DepartmentId)
                .IsRequired()
                .HasColumnName("departamentIdFk");

            //--Relations 
            builder.HasOne(e => e.Department)
                .WithMany(p => p.Cities)
                .HasForeignKey(p => p.DepartmentId);

            builder.HasData(
                new {
                    Id=1,
                    Name = "Bucaramanga",
                    DepartmentId = 1
                },
                new {
                    Id=2,
                    Name = "Florida Blanca",
                    DepartmentId = 1
                },
                new {
                    Id=3,
                    Name = "San Gil",
                    DepartmentId = 1
                },
                new {
                    Id=4,
                    Name = "Barichara",
                    DepartmentId = 1
                }
            );
        }

}