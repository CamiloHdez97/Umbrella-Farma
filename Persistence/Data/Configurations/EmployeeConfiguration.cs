using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {
    public void Configure(EntityTypeBuilder<Employee> builder){
        builder.ToTable("employee");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        builder.Property(x => x.ChargeId)
            .IsRequired()
            .HasColumnName("ChargeId");

        builder.Property(x => x.PersonId)
            .IsRequired()
            .HasColumnName("PersonId");

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
    }    
}