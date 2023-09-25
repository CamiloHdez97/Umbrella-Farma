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
        
        builder.Property(x => x.UserName)
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
            p.UserName,p.Email
        })
        .HasDatabaseName("IX_Username_Email")
        .IsUnique();
        
        //-Relations
        builder.HasMany(x => x.Roles)
            .WithMany(r => r.Users) 
            .UsingEntity<UserRol>(
                j => j
                .HasOne(pt => pt.Role)
                .WithMany(t => t.UserRols)
                .HasForeignKey(ut => ut.RoleId),
                j => j
                .HasOne(et => et.User)
                .WithMany(et => et.UserRols)
                .HasForeignKey(el => el.UserId),

                j =>
                {
                    j.HasKey(t => new { t.UserId, t.RoleId });
           }); 

           builder.HasData(
                new{
                    Id = 1,
                    UserName = "root",
                    Password = "root",
                    PersonId = 1
                }

           );
    }
}