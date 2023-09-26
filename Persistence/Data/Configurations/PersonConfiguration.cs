using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("person");
        builder.HasKey(p => p.Id);

        //--Properties
        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");
        
        builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasMaxLength(50);

        builder.Property(p => p.RegisterDate)
                .HasColumnName("registerdate")
                .IsRequired()
                .HasColumnType("DateTime");

        builder.Property(p => p.BirthDate)
                .HasColumnName("birthdate")
                .IsRequired()
                .HasColumnType("DateTime");     

        builder.Property(p => p.PersonTypeId)
            .IsRequired()
            .HasColumnName("personTypeIdFk");

        builder.Property(p => p.DocumentTypeId)
            .IsRequired()
            .HasColumnName("documentTypeIdFk");

        // --Relations  
        builder.HasOne(p => p.DocumentType)
            .WithMany(m => m.Persons)
            .HasForeignKey(p => p.DocumentTypeId);

        builder.HasOne(p => p.PersonType)
            .WithMany(m => m.Person)
            .HasForeignKey(p => p.PersonTypeId);


        builder.HasData(
            new{
                Id=1,
                Name = "root",
                RegisterDate = DateTime.Now,
                BirthDate = DateTime.Now,                
                TypePersonId = 1,                
                DocumentTypeId = 3,                
                DocumentNumber = "0000000000",                
            },
            new{
                Id=2,
                Name = "ProveedorA",
                RegisterDate = DateTime.Now,
                BirthDate = DateTime.Now,
                TypePersonId = 2,
                DocumentTypeId = 3,                
                DocumentNumber = "0000000001",                
            },
            new{
                Id=3,
                Name = "ProveedorB",
                RegisterDate = DateTime.Now,
                BirthDate = DateTime.Now,
                TypePersonId = 2,
                DocumentTypeId = 3,                
                DocumentNumber = "0000000002",                
            },
            new{
                Id=4,
                Name = "ProveedorC",
                RegisterDate = DateTime.Now,
                BirthDate = DateTime.Now,
                TypePersonId = 2,
                DocumentTypeId = 3,                
                DocumentNumber = "0000000003",                
            },
            new{
                Id=5,
                Name = "Juan Paco",
                RegisterDate = DateTime.Now,
                BirthDate = new DateTime(2020,1,1),
                TypePersonId = 1,
                DocumentTypeId = 1,                
                DocumentNumber = "546869433",
            },
            new{
                Id=6,
                Name = "Pedro De La Mar",
                RegisterDate = new DateTime(2020,1,1),
                BirthDate = new DateTime(1990,1,1),
                TypePersonId = 1,
                DocumentTypeId = 1,                
                DocumentNumber = "546869433",
            },
            new{
                Id=7,
                Name = "Maria Db",
                RegisterDate = DateTime.Now,
                BirthDate = new DateTime(2014,7,3),
                TypePersonId = 1,
                DocumentTypeId = 2,                
                DocumentNumber = "1000354228",
            },
            new{
                Id=8,
                Name = "Ana frank",
                RegisterDate = new DateTime(2019,05,15),
                BirthDate = new DateTime(1929,7,12),
                TypePersonId = 1,
                DocumentTypeId = 1,                
                DocumentNumber = "555903923",
            },
            new{
                Id=9,
                Name = "Luis Fonsi",
                RegisterDate = new DateTime(2018,2,10),
                BirthDate = new DateTime(1978,4,15),
                TypePersonId = 1,
                DocumentTypeId = 1,                
                DocumentNumber = "123456789",
            },
            new{
                Id=10,
                Name = "Sena Sofia",
                RegisterDate = new DateTime(2021,3,1),
                BirthDate = new DateTime(1957,12,21),
                TypePersonId = 1,
                DocumentTypeId = 1,                
                DocumentNumber = "4355466753",
            },
            new{
                Id=11,
                Name = "Elena de avalord",
                RegisterDate = new DateTime(2001,6,30),
                BirthDate = new DateTime(1987,12,21),
                TypePersonId = 1,
                DocumentTypeId = 1,                
                DocumentNumber = "74328957843",
            }
        );
    }
}

