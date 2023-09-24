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
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Name).HasColumnName("name")
            .HasColumnType("varchar").IsRequired().HasMaxLength(30);
        }
    }

}