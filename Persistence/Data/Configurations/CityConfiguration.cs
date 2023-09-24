using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder){
            
            builder.ToTable("city");
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_city")
                .HasColumnType("int")
                .IsRequired();
    
            builder.Property(p => p.Name).HasColumnName("name")
            .HasColumnType("varchar").IsRequired().HasMaxLength(58);

            builder.HasOne(e => e.Department).WithMany(p => p.Cities).HasForeignKey(p => p.DepartmentId);

        }

}