using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>{
        public void Configure(EntityTypeBuilder<Department> builder){
            builder.ToTable("department");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_department")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Name).HasColumnName("name")
            .HasColumnType("varchar").IsRequired().HasMaxLength(50);

            builder.HasOne(p => p.Country).WithMany(p => p.Departments).HasForeignKey(p => p.CountryId);

        }
    }

}