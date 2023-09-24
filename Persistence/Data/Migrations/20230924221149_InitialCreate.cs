using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "charge",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    chargename = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_charge", x => x.idPk);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contactCategory",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    contactcategoryname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactCategory", x => x.idPk);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contacttype",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    contacttypename = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacttype", x => x.idPk);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    id_country = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.id_country);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "epstype",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    epstypename = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_epstype", x => x.idPk);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicine_brand",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicine_brand", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicine_category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicine_category", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicine_presentation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicine_presentation", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descriptionRole = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.idPk);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "suppliertype",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    suppliertypename = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliertype", x => x.idPk);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    id_department = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.id_department);
                    table.ForeignKey(
                        name: "FK_department_country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "country",
                        principalColumn: "id_country",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicineInfo",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<float>(type: "float", nullable: false),
                    discount = table.Column<float>(type: "float", nullable: false),
                    image = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    requiredRecipe = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    medicineBrandId = table.Column<int>(type: "int", nullable: false),
                    medicinePresentationId = table.Column<int>(type: "int", nullable: false),
                    medicineCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicineInfo", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_medicineInfo_medicine_brand_medicineBrandId",
                        column: x => x.medicineBrandId,
                        principalTable: "medicine_brand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicineInfo_medicine_category_medicineCategoryId",
                        column: x => x.medicineCategoryId,
                        principalTable: "medicine_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicineInfo_medicine_presentation_medicinePresentationId",
                        column: x => x.medicinePresentationId,
                        principalTable: "medicine_presentation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    personname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastname = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    registerdate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    birthdate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    TypePersonId = table.Column<int>(type: "int", nullable: false),
                    PersonTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_person_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_person_PersonTypes_PersonTypeId",
                        column: x => x.PersonTypeId,
                        principalTable: "PersonTypes",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    id_city = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(58)", maxLength: 58, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.id_city);
                    table.ForeignKey(
                        name: "FK_city_department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "department",
                        principalColumn: "id_department",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inventory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    location = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalStock = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    MedicineInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory", x => x.id);
                    table.ForeignKey(
                        name: "FK_inventory_medicineInfo_MedicineInfoId",
                        column: x => x.MedicineInfoId,
                        principalTable: "medicineInfo",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    personId = table.Column<int>(type: "int", nullable: false),
                    contactTypeId = table.Column<int>(type: "int", nullable: false),
                    ContactCategoryId = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => new { x.personId, x.contactTypeId, x.ContactCategoryId });
                    table.ForeignKey(
                        name: "FK_contact_contactCategory_ContactCategoryId",
                        column: x => x.ContactCategoryId,
                        principalTable: "contactCategory",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contact_contacttype_contactTypeId",
                        column: x => x.contactTypeId,
                        principalTable: "contacttype",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contact_person_personId",
                        column: x => x.personId,
                        principalTable: "person",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ChargeId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_employee_charge_ChargeId",
                        column: x => x.ChargeId,
                        principalTable: "charge",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "eps",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    EpsTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eps", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_eps_epstype_EpsTypeId",
                        column: x => x.EpsTypeId,
                        principalTable: "epstype",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_eps_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "supplier",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SupplierTypeId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_supplier_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_supplier_suppliertype_SupplierTypeId",
                        column: x => x.SupplierTypeId,
                        principalTable: "suppliertype",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    accessToken = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    refreshToken = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_user_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    id_address = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_neigborhood = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type_way = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quadran_prefix = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    number_way = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_venereableWay = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    number_plate = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.id_address);
                    table.ForeignKey(
                        name: "FK_address_city_CityId",
                        column: x => x.CityId,
                        principalTable: "city",
                        principalColumn: "id_city",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_address_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InventoryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    MedicineInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicines_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicines_inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "inventory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicines_medicineInfo_MedicineInfoId",
                        column: x => x.MedicineInfoId,
                        principalTable: "medicineInfo",
                        principalColumn: "idPk");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sale",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    saledate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: false),
                    personId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_sale_employee_employeeId",
                        column: x => x.employeeId,
                        principalTable: "employee",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sale_person_personId",
                        column: x => x.personId,
                        principalTable: "person",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "eps_employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EpsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eps_employee", x => new { x.EpsId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_eps_employee_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_eps_employee_eps_EpsId",
                        column: x => x.EpsId,
                        principalTable: "eps",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "shopping",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    shoppingDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    supplierId = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shopping", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_shopping_employee_employeeId",
                        column: x => x.employeeId,
                        principalTable: "employee",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shopping_supplier_supplierId",
                        column: x => x.supplierId,
                        principalTable: "supplier",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRol",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRol", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRol_role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "role",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRol_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "recipe",
                columns: table => new
                {
                    idPk = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    recipedate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    expirationdate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    detail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    EpsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_recipe_eps_EpsId",
                        column: x => x.EpsId,
                        principalTable: "eps",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recipe_sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "sale",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "saleDetail",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saleDetail", x => new { x.MedicineId, x.SaleId });
                    table.ForeignKey(
                        name: "FK_saleDetail_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_saleDetail_sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "sale",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "shoppingDetail",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    ShoppingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingDetail", x => new { x.MedicineId, x.ShoppingId });
                    table.ForeignKey(
                        name: "FK_shoppingDetail_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shoppingDetail_shopping_ShoppingId",
                        column: x => x.ShoppingId,
                        principalTable: "shopping",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_address_CityId",
                table: "address",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_address_PersonId",
                table: "address",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_city_DepartmentId",
                table: "city",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_contact_ContactCategoryId",
                table: "contact",
                column: "ContactCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_contact_contactTypeId",
                table: "contact",
                column: "contactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_department_CountryId",
                table: "department",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_ChargeId",
                table: "employee",
                column: "ChargeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_PersonId",
                table: "employee",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eps_EpsTypeId",
                table: "eps",
                column: "EpsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_eps_PersonId",
                table: "eps",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eps_employee_EmployeeId",
                table: "eps_employee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_inventory_MedicineInfoId",
                table: "inventory",
                column: "MedicineInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_medicineInfo_medicineBrandId",
                table: "medicineInfo",
                column: "medicineBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_medicineInfo_medicineCategoryId",
                table: "medicineInfo",
                column: "medicineCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_medicineInfo_medicinePresentationId",
                table: "medicineInfo",
                column: "medicinePresentationId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_InventoryId",
                table: "Medicines",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_MedicineInfoId",
                table: "Medicines",
                column: "MedicineInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_StateId",
                table: "Medicines",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_person_DocumentTypeId",
                table: "person",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_person_PersonTypeId",
                table: "person",
                column: "PersonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_EpsId",
                table: "recipe",
                column: "EpsId");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_SaleId",
                table: "recipe",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_sale_employeeId",
                table: "sale",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_sale_personId",
                table: "sale",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_saleDetail_SaleId",
                table: "saleDetail",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_shopping_employeeId",
                table: "shopping",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_shopping_supplierId",
                table: "shopping",
                column: "supplierId");

            migrationBuilder.CreateIndex(
                name: "IX_shoppingDetail_ShoppingId",
                table: "shoppingDetail",
                column: "ShoppingId");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_PersonId",
                table: "supplier",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_SupplierTypeId",
                table: "supplier",
                column: "SupplierTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_user_PersonId",
                table: "user",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Username_Email",
                table: "user",
                columns: new[] { "username", "email" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRol_RoleId",
                table: "UserRol",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "contact");

            migrationBuilder.DropTable(
                name: "eps_employee");

            migrationBuilder.DropTable(
                name: "recipe");

            migrationBuilder.DropTable(
                name: "saleDetail");

            migrationBuilder.DropTable(
                name: "shoppingDetail");

            migrationBuilder.DropTable(
                name: "UserRol");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "contactCategory");

            migrationBuilder.DropTable(
                name: "contacttype");

            migrationBuilder.DropTable(
                name: "eps");

            migrationBuilder.DropTable(
                name: "sale");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "shopping");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropTable(
                name: "epstype");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "inventory");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "supplier");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "medicineInfo");

            migrationBuilder.DropTable(
                name: "charge");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "suppliertype");

            migrationBuilder.DropTable(
                name: "medicine_brand");

            migrationBuilder.DropTable(
                name: "medicine_category");

            migrationBuilder.DropTable(
                name: "medicine_presentation");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "PersonTypes");
        }
    }
}
