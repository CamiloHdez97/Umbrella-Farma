using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class EpsConfiguration : IEntityTypeConfiguration<Eps>{
    public void Configure(EntityTypeBuilder<Eps> builder) 
    {
        builder.ToTable("eps");
        builder.HasKey(p => p.Id);

        //--Properties
        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        //--Relations
        builder.HasOne(p => p.EpsType)
            .WithMany(m => m.Epss)
            .HasForeignKey(p => p.EpsTypeId);

        builder.HasOne(p => p.Person)
            .WithOne(m => m.PersonEps)
            .HasForeignKey<Eps>(p => p.PersonId);
    }
}