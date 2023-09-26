using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {
    public void Configure(EntityTypeBuilder<Employee> builder){
        builder.ToTable("employee");
        builder.HasKey(p => p.Id);

        //--Properties
        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        builder.Property(x => x.ChargeId)
            .IsRequired()
            .HasColumnName("chargeIdFk");

        builder.Property(x => x.PersonId)
            .IsRequired()
            .HasColumnName("personIdFk");

        //--Relations
        builder.HasOne(x => x.Charge)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.ChargeId);
        
        builder.HasOne(x => x.Person)
            .WithOne(x => x.Employee)
            .HasForeignKey<Employee>(x => x.PersonId);        

        builder.HasMany(p => p.Eps)
            .WithMany(p => p.Employees)
            .UsingEntity<EpsEmployee>(
                t => t.HasOne(j => j.Eps)
                    .WithMany(j => j.EpsEmployees)
                    .HasForeignKey(j => j.EpsId),
                t => t.HasOne(j => j.Employee)
                    .WithMany(j => j.EpsEmployees)
                    .HasForeignKey(j => j.EmployeeId),
                t => {//--Configurations
                    t.ToTable("eps_employee");
                    t.HasKey(j => new{j.EpsId,j.EmployeeId});
        
                    
                }
            );   

        builder.HasData(
            new{
                Id=1,                
                ChargeId = 1,
                PersonId = 6
            },
            new{
                Id=2,
                ChargeId = 1,
                PersonId = 8
            },
            new{
                Id=3,
                ChargeId = 2,
                PersonId = 9
            },
            new{
                Id=4,
                ChargeId = 3,
                PersonId = 10
            }
        );
    }    
}