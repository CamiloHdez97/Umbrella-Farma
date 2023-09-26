using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>{
    public void Configure(EntityTypeBuilder<Recipe> builder){
        builder.ToTable("recipe");
        builder.HasKey(p => p.Id);

        //--Properties
        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        builder.Property(p => p.RecipeDate)
            .HasColumnName("recipedate")
            .IsRequired()
            .HasColumnType("DateTime");

        builder.Property(p => p.ExpirationDate)
            .HasColumnName("expirationdate")
            .IsRequired()
            .HasColumnType("DateTime");
        
        builder.Property(p => p.Detail)
            .IsRequired()
            .HasColumnName("detail")
            .HasMaxLength(100);

        //--Relations
        builder.HasOne(p => p.Sale)
            .WithMany(m => m.Recipes)
            .HasForeignKey(p => p.SaleId);
    }
}