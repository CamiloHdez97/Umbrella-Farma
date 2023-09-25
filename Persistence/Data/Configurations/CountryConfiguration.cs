using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("country");
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_country")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Name).HasColumnName("name")
            .HasColumnType("varchar").IsRequired().HasMaxLength(50);

            builder.HasData(
                new {
                    Id=1,
                    Name = "Colombia"
                }
            );
        }
    }

}