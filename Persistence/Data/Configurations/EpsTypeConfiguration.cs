using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class EpsTypeConfiguration : IEntityTypeConfiguration<EpsType>{
    public void Configure(EntityTypeBuilder<EpsType> builder){
        builder.ToTable("epstype");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");
        
        builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("epstypename")
            .HasMaxLength(50);

        // Relations
    }
}