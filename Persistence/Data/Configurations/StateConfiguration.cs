using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("state");
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Description).HasColumnName("description")
            .HasColumnType("varchar").IsRequired().HasMaxLength(50);

            builder.HasData(
                new{
                    Id = 1,
                    Description = "default"
                },
                new{
                    Id = 2,
                    Description = "expired"
                },
                new{
                    Id = 3,
                    Description = "damaged"
                },
                new{
                    Id = 4,
                    Description = "Sold"
                },
                new{
                    Id = 5,
                    Description = "Returned"
                }
            );
        }
    }

}