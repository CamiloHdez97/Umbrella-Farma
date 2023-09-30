using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class RoleConfiguration : IEntityTypeConfiguration<Role>{
    public void Configure(EntityTypeBuilder<Role> builder){
        builder.ToTable("role");
        builder.HasKey(x => x.Id);
        
        //--Properties
        builder.Property(x => x.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");
        
        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("descriptionRole")
            .HasMaxLength(250);   


        builder.HasData(
            new{
                Id =1,
                Description = "Administrator"
            },
            new{
                Id =2,
                Description = "Employee"
            },
            new{
                Id =3,
                Description = "Manager"
            }
        );
    }
}