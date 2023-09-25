using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("address");

        builder.Property(p => p.Id)
          .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
          .HasColumnName("id_address")
          .HasColumnType("int")
          .IsRequired();

        builder.Property(p => p.Neigborhood)
          .HasColumnName("name_neigborhood")
          .HasColumnType("varchar")
          .HasMaxLength(200)
          .IsRequired();

            
        builder.Property(p => p.TypeWay)
          .HasColumnName("type_way")
          .HasColumnType("varchar")
          .HasMaxLength(200)
          .IsRequired();

  
        builder.Property(p => p.NumberWay)
          .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
          .HasColumnName("number_way")
          .HasColumnType("varchar")
          .HasMaxLength(200)
          .IsRequired();

        builder.Property(p => p.QuadrantPrefix)
          .HasColumnName("quadran_prefix")
          .HasColumnType("varchar")
          .HasMaxLength(200)
          .IsRequired();

        builder.Property(p => p.NumberVenereableWay)
          .HasColumnName("name_venereableWay")
          .HasColumnType("varchar")
          .HasMaxLength(200)
          .IsRequired();

        builder.Property(p => p.NumberPlate)
          .HasColumnName("number_plate")
          .HasColumnType("varchar")
          .HasMaxLength(200)
          .IsRequired();


        builder.HasOne(p => p.Person)
          .WithMany(p => p.Addresses)
          .HasForeignKey(p => p.PersonId);

        builder.HasOne(p => p.City)
          .WithMany(p => p.Addresses)
          .HasForeignKey(p => p.CityId);

        
    }
}
