using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class MedicineInfoConfiguration : IEntityTypeConfiguration<MedicineInfo>{
    public void Configure(EntityTypeBuilder<MedicineInfo> builder){
        builder.ToTable("medicineInfo");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasMaxLength(50);
        
        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnName("description")
            .HasMaxLength(250);
        
        builder.Property(x => x.Price)
            .IsRequired()
            .HasColumnName("price");

        builder.Property(x => x.Discount)
            .IsRequired()
            .HasColumnName("discount");
        
        builder.Property(x => x.Image)
            .IsRequired()
            .HasColumnName("image")
            .HasMaxLength(250);
        
        builder.Property(x => x.RequiredRecipe)
            .IsRequired()
            .HasColumnName("requiredRecipe");
        
        builder.Property(x => x.MedicineBrandId)
            .IsRequired()
            .HasColumnName("medicineBrandId");
        
        builder.Property(x => x.MedicinePresentationId)
            .IsRequired()
            .HasColumnName("medicinePresentationId");
        
        builder.Property(x => x.MedicineCategoryId)
            .IsRequired()
            .HasColumnName("medicineCategoryId");
        
        builder.HasOne(x => x.MedicinePresentation)
            .WithMany(x => x.Medicines)
            .HasForeignKey(x => x.MedicinePresentationId);
        
        builder.HasOne(x => x.MedicineCategory)
            .WithMany(x => x.MedicineInfos)
            .HasForeignKey(x => x.MedicineCategoryId);
        
        builder.HasOne(x => x.MedicineBrand)
            .WithMany(x => x.MedicineInfos)
            .HasForeignKey(x => x.MedicineBrandId);
        
        
        
                
    }
}