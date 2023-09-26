using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("department");

            //--Properties
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("departmentid")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Name)
                .HasColumnName("name")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.CountryId)
                .IsRequired()
                .HasColumnName("countryIdFk");
            
            //--Relations
            builder.HasOne(p => p.Country)
                .WithMany(m => m.Departments)
                .HasForeignKey(p => p.CountryId);

            builder.HasData(
                new {
                    Id=1,
                    Name = "Santander",
                    CountryId = 1,                    
                }
            );
        }
    }

}