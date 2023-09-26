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
<<<<<<< HEAD
            .WithOne(m => m.PersonEps)
            .HasForeignKey<Eps>(p => p.PersonId);
=======
            .WithMany(m => m.Epss)
            .HasForeignKey(p => p.PersonId);

>>>>>>> 33611803cbfbb92657e716e175d861f8d03dd928
    }
    
}