using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class UserConfiguration : IEntityTypeConfiguration<User>{
    public void Configure(EntityTypeBuilder<User> builder){
        builder.ToTable("user");
        builder.HasKey(x => x.Id);

        //--Properties
        builder.Property(x => x.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("username")
            .HasMaxLength(50);
        
        builder.Property(x => x.Email)            
            .HasColumnName("email")
            .HasMaxLength(100);
        
        builder.Property(x => x.Password)
            .IsRequired()
            .HasColumnName("password")
            .HasMaxLength(200);

        builder.Property(x => x.AccessToken)
            .HasColumnName("accessToken")
            .HasMaxLength(500);
        
        builder.Property(x => x.RefreshToken)
            .HasColumnName("refreshToken")
            .HasMaxLength(500);
        
        builder.HasIndex(p => new{
            p.Name,p.Email
        })
        .HasDatabaseName("IX_Username_Email")
        .IsUnique();
        
        //-Relations
        builder.HasOne(x => x.Role)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.RoleId);   
    }
}