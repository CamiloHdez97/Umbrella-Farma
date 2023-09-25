using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class PersonConfiguration : IEntityTypeConfiguration<Person>{
    public void Configure(EntityTypeBuilder<Person> builder){
        builder.ToTable("person");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");
        
        builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("personname")
            .HasMaxLength(50);

        builder.Property(p => p.RegisterDate)
                .HasColumnName("registerdate")
                .IsRequired()
                .HasColumnType("DateTime");

        builder.Property(p => p.BirthDate)
                .HasColumnName("birthdate")
                .IsRequired()
                .HasColumnType("DateTime");

        builder.HasData(
            new{
                Id=1,
                Name = "root",
                RegisterDate = DateTime.Now,
                BirthDate = DateTime.Now,                
                TypePersonId = 1,                
                DocumentTypeId = 3,                
                DocumentNumber = "0000000000",                
            }
        );
    }
}

