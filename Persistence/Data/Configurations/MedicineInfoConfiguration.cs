using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;
public class MedicineInfoConfiguration : IEntityTypeConfiguration<MedicineInfo>
{
    public void Configure(EntityTypeBuilder<MedicineInfo> builder)
    {
        builder.ToTable("medicineInfo");
        builder.HasKey(x => x.Id);

        //--Properties
        builder.Property(p => p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("idPk");

        builder.Property(p => p.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasMaxLength(50);
        
        builder.Property(p => p.Description)
            .IsRequired()
            .HasColumnName("description")
            .HasMaxLength(250);
        
        builder.Property(p => p.Price)
           .IsRequired()
            .HasColumnName("price");

        builder.Property(p => p.Discount)
            .IsRequired()
            .HasColumnName("discount");
        
        builder.Property(p => p.Image)
            .IsRequired()
            .HasColumnName("image")
            .HasMaxLength(500);
        
        builder.Property(p => p.RequiredRecipe)
            .IsRequired()
            .HasColumnName("requiredRecipe");
        
        builder.Property(p => p.MedicineBrandId)
            .IsRequired()
            .HasColumnName("medicineBrandId");
        
        builder.Property(p => p.MedicinePresentationId)
            .IsRequired()
            .HasColumnName("medicinePresentationId");
        
        builder.Property(p => p.MedicineCategoryId)
            .IsRequired()
            .HasColumnName("medicineCategoryId");

        //--Relations
        builder.HasOne(p => p.MedicinePresentation)
            .WithMany(p => p.Medicines)
            .HasForeignKey(p => p.MedicinePresentationId);
        
        builder.HasOne(p => p.MedicineCategory)
            .WithMany(p => p.MedicineInfos)
            .HasForeignKey(p => p.MedicineCategoryId);
        
        builder.HasOne(p => p.MedicineBrand)
            .WithMany(p => p.MedicineInfos)
            .HasForeignKey(p => p.MedicineBrandId);
        

        builder.HasData(
            new{
                Id=1,
                Name="Paracetamol",
                Description="Alivia el dolor leve y moderado,\nVia oral 10 comprimidos",
                Image ="https://www.pmfarma.com/noticias/noticias/34179/image/gelocatil%20ferrer%20iqvia%20consumo%20de%20paracetamol%20ha%20aumentado.jpg",
                Price =(float) 20,
                Discount=(float) 0,
                RequiredRecipe = true,
                MedicineBrandId = 5,
                MedicinePresentationId = 1,
                MedicineCategoryId =1
            },
            new{
                Id=2,
                Name="Ibuprofeno",
                Description="30 tabletas cubiertas de 1g",
                Image ="https://drogueriasantamaria.com/rails/active_storage/representations/proxy/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBOG9nQmc9PSIsImV4cCI6bnVsbCwicHVyIjoiYmxvYl9pZCJ9fQ==--89153d1d91681a39dfe201c944bf3c3f4d47ab2a/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaDdCem9MWm05eWJXRjBTU0lJYW5CbkJqb0dSVlE2RW5KbGMybDZaVjkwYjE5bWFYUmJCMmtDSUFOcEFpQUQiLCJleHAiOm51bGwsInB1ciI6InZhcmlhdGlvbiJ9fQ==--70dc4abb6ac52505d9b5c972f6eb61cd265c8cf9/7702057164157-11.jpg?locale=es",
                Price =(float) 25,
                Discount=(float) 5,
                RequiredRecipe = true,
                MedicineBrandId = 2,
                MedicinePresentationId = 1,
                MedicineCategoryId =1
            },
            new{
                Id=3,
                Name="Aspirina",
                Description="104 tabletas de 100mg",
                Image ="https://copservir.vtexassets.com/arquivos/ids/1028189/ASPIRINA-100_F.png?v=638292392290900000",
                Price =(float) 15,
                Discount=(float) 10,
                RequiredRecipe = true,
                MedicineBrandId = 5,
                MedicinePresentationId = 1,
                MedicineCategoryId =1
            },
            new{
                Id=4,
                Name="Amoxicilina",
                Description="50 capsulas 500mg",
                Image ="https://copservir.vtexassets.com/arquivos/ids/1027177-800-auto?v=638292281540200000&width=800&height=auto&aspect=true",
                Price =(float) 40,
                Discount=(float) 0,
                RequiredRecipe = true,
                MedicineBrandId = 3,
                MedicinePresentationId = 3,
                MedicineCategoryId =1
            },
            new{
                Id=5,
                Name="Cetirizina",
                Description="10 tabletas 10mg",
                Image ="https://copservir.vtexassets.com/arquivos/ids/989672-800-auto?v=638243980849430000&width=800&height=auto&aspect=true",
                Price =(float) 10,
                Discount=(float) 0,
                RequiredRecipe = true,
                MedicineBrandId = 7,
                MedicinePresentationId = 1,
                MedicineCategoryId =1
            },
            new{
                Id=6,
                Name="Losartan",
                Description="30 tabletas recubiertas de 50mg via oral",
                Image ="https://pasteurio.vtexassets.com/arquivos/ids/174364/Salud-y-Medicamentos-Medicamentos-formulados_Genfar_Pasteur_134452_caja_01.jpg?v=638031144709070000",
                Price =(float) 55,
                Discount=(float) 0,
                RequiredRecipe = true,
                MedicineBrandId = 7,
                MedicinePresentationId = 1,
                MedicineCategoryId =1
            },
            new{
                Id=7,
                Name="Metformina",
                Description="30 tabletas de 850mg",
                Image ="https://pymstatic.com/43895/conversions/metformina-wide.jpg",
                Price =(float) 60,
                Discount=(float) 40,
                RequiredRecipe = true,
                MedicineBrandId = 2,
                MedicinePresentationId = 1,
                MedicineCategoryId =1
            },
            new{
                Id=8,
                Name="Atorvastatina",
                Description="30 tabletas recubiertas de 30mg",
                Image ="https://www.farmalisto.com.co/154365/atorvastatina-10-mg-la-sante-caja-con-30-tabletas.jpg",
                Price =(float) 45,
                Discount=(float) 12,
                RequiredRecipe = true,
                MedicineBrandId = 3,
                MedicinePresentationId = 1,
                MedicineCategoryId =1
            },
            new{
                Id=9,
                Name="Clonazepam",
                Description="30 tabletas recubiertas de 2mg",
                Image ="https://farmastore.com.ve/192-large_default/sedatril-clonazepam-tq-2-mg-x-30-tabletas-rivotril.jpg",
                Price =(float) 35,
                Discount=(float) 0,
                RequiredRecipe = true,
                MedicineBrandId = 1,
                MedicinePresentationId = 1,
                MedicineCategoryId =1
            },
            new{
                Id=10,
                Name="Loratadina",
                Description="5 mg / 5ml jarabe de 100ml",
                Image ="https://www.drogueriasanjorge.com/wp-content/uploads/2012/03/7702605101641_A1N1_es_s01.jpg",
                Price =(float) 22,
                Discount=(float) 0,
                RequiredRecipe = true,
                MedicineBrandId = 7,
                MedicinePresentationId = 2,
                MedicineCategoryId =2
            }

        );        
    }
}