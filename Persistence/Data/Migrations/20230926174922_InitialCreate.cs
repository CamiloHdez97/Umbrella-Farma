using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    chargeName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
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
                name: "documenttype",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documenttype", x => x.id);
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
                name: "medicinepresentation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicinepresentation", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "persontype",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persontype", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descriptionRole = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.idPk);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.id);
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
                    departmentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    countryIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.departmentid);
                    table.ForeignKey(
                        name: "FK_department_country_countryIdFk",
                        column: x => x.countryIdFk,
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
                    image = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
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
                        name: "FK_medicineInfo_medicinepresentation_medicinePresentationId",
                        column: x => x.medicinePresentationId,
                        principalTable: "medicinepresentation",
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
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    registerdate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    birthdate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DocumentNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    documentTypeIdFk = table.Column<int>(type: "int", nullable: false),
                    personTypeIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_person_documenttype_documentTypeIdFk",
                        column: x => x.documentTypeIdFk,
                        principalTable: "documenttype",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_person_persontype_personTypeIdFk",
                        column: x => x.personTypeIdFk,
                        principalTable: "persontype",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    id_city = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    departamentIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.id_city);
                    table.ForeignKey(
                        name: "FK_city_department_departamentIdFk",
                        column: x => x.departamentIdFk,
                        principalTable: "department",
                        principalColumn: "departmentid",
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
                    medicineInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory", x => x.id);
                    table.ForeignKey(
                        name: "FK_inventory_medicineInfo_medicineInfoId",
                        column: x => x.medicineInfoId,
                        principalTable: "medicineInfo",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    personIdFk = table.Column<int>(type: "int", nullable: false),
                    contactTypeIdFk = table.Column<int>(type: "int", nullable: false),
                    ContactCategoryIdFk = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => new { x.personIdFk, x.contactTypeIdFk, x.ContactCategoryIdFk });
                    table.ForeignKey(
                        name: "FK_contact_contactCategory_ContactCategoryIdFk",
                        column: x => x.ContactCategoryIdFk,
                        principalTable: "contactCategory",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contact_contacttype_contactTypeIdFk",
                        column: x => x.contactTypeIdFk,
                        principalTable: "contacttype",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contact_person_personIdFk",
                        column: x => x.personIdFk,
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
                    chargeIdFk = table.Column<int>(type: "int", nullable: false),
                    personIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_employee_charge_chargeIdFk",
                        column: x => x.chargeIdFk,
                        principalTable: "charge",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_person_personIdFk",
                        column: x => x.personIdFk,
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
                    description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    personIdFk = table.Column<int>(type: "int", nullable: false),
                    cityIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.id_address);
                    table.ForeignKey(
                        name: "FK_address_city_cityIdFk",
                        column: x => x.cityIdFk,
                        principalTable: "city",
                        principalColumn: "id_city",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_address_person_personIdFk",
                        column: x => x.personIdFk,
                        principalTable: "person",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicine",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    creation_date = table.Column<DateTime>(type: "date", nullable: false),
                    expiration_date = table.Column<DateTime>(type: "date", nullable: false),
                    inventoryIdFk = table.Column<int>(type: "int", nullable: false),
                    stateIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicine", x => x.id);
                    table.ForeignKey(
                        name: "FK_medicine_inventory_inventoryIdFk",
                        column: x => x.inventoryIdFk,
                        principalTable: "inventory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicine_state_stateIdFk",
                        column: x => x.stateIdFk,
                        principalTable: "state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    saleIdFk = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_recipe_sale_saleIdFk",
                        column: x => x.saleIdFk,
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
                        name: "FK_saleDetail_medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "medicine",
                        principalColumn: "id",
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
                        name: "FK_shoppingDetail_medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "medicine",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shoppingDetail_shopping_ShoppingId",
                        column: x => x.ShoppingId,
                        principalTable: "shopping",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "charge",
                columns: new[] { "idPk", "chargeName" },
                values: new object[,]
                {
                    { 1, "seller" },
                    { 2, "manager" },
                    { 3, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "contactCategory",
                columns: new[] { "idPk", "contactcategoryname" },
                values: new object[,]
                {
                    { 1, "Email" },
                    { 2, "Phone" },
                    { 3, "telepathic" }
                });

            migrationBuilder.InsertData(
                table: "contacttype",
                columns: new[] { "idPk", "contacttypename" },
                values: new object[,]
                {
                    { 1, "staff" },
                    { 2, "profesional" }
                });

            migrationBuilder.InsertData(
                table: "country",
                columns: new[] { "id_country", "name" },
                values: new object[] { 1, "Colombia" });

            migrationBuilder.InsertData(
                table: "documenttype",
                columns: new[] { "id", "description" },
                values: new object[,]
                {
                    { 1, "CC" },
                    { 2, "TI" },
                    { 3, "NIT" }
                });

            migrationBuilder.InsertData(
                table: "medicine_brand",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "TQ" },
                    { 2, "MK" },
                    { 3, "La Sante" },
                    { 4, "Durafex" },
                    { 5, "Ferrer" },
                    { 6, "Bayer" },
                    { 7, "Genfar" }
                });

            migrationBuilder.InsertData(
                table: "medicine_category",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Legal" },
                    { 2, "Illegal" }
                });

            migrationBuilder.InsertData(
                table: "medicinepresentation",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "tablets" },
                    { 2, "syrups" },
                    { 3, "capsule" }
                });

            migrationBuilder.InsertData(
                table: "persontype",
                columns: new[] { "id", "description" },
                values: new object[,]
                {
                    { 1, "Natural" },
                    { 2, "Juridica" }
                });

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "idPk", "descriptionRole" },
                values: new object[] { 1, "Administrator" });

            migrationBuilder.InsertData(
                table: "state",
                columns: new[] { "id", "description" },
                values: new object[,]
                {
                    { 1, "default" },
                    { 2, "expired" },
                    { 3, "damaged" },
                    { 4, "Sold" },
                    { 5, "Returned" }
                });

            migrationBuilder.InsertData(
                table: "suppliertype",
                columns: new[] { "idPk", "suppliertypename" },
                values: new object[,]
                {
                    { 1, "Drugs" },
                    { 2, "syrups" },
                    { 3, "hallucinogens" }
                });

            migrationBuilder.InsertData(
                table: "department",
                columns: new[] { "departmentid", "countryIdFk", "name" },
                values: new object[] { 1, 1, "Santander" });

            migrationBuilder.InsertData(
                table: "medicineInfo",
                columns: new[] { "idPk", "description", "discount", "image", "medicineBrandId", "medicineCategoryId", "medicinePresentationId", "name", "price", "requiredRecipe" },
                values: new object[,]
                {
                    { 1, "Alivia el dolor leve y moderado,\nVia oral 10 comprimidos", 0f, "https://www.pmfarma.com/noticias/noticias/34179/image/gelocatil%20ferrer%20iqvia%20consumo%20de%20paracetamol%20ha%20aumentado.jpg", 5, 1, 1, "Paracetamol", 20f, true },
                    { 2, "30 tabletas cubiertas de 1g", 5f, "https://drogueriasantamaria.com/rails/active_storage/representations/proxy/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBOG9nQmc9PSIsImV4cCI6bnVsbCwicHVyIjoiYmxvYl9pZCJ9fQ==--89153d1d91681a39dfe201c944bf3c3f4d47ab2a/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaDdCem9MWm05eWJXRjBTU0lJYW5CbkJqb0dSVlE2RW5KbGMybDZaVjkwYjE5bWFYUmJCMmtDSUFOcEFpQUQiLCJleHAiOm51bGwsInB1ciI6InZhcmlhdGlvbiJ9fQ==--70dc4abb6ac52505d9b5c972f6eb61cd265c8cf9/7702057164157-11.jpg?locale=es", 2, 1, 1, "Ibuprofeno", 25f, true },
                    { 3, "104 tabletas de 100mg", 10f, "https://copservir.vtexassets.com/arquivos/ids/1028189/ASPIRINA-100_F.png?v=638292392290900000", 5, 1, 1, "Aspirina", 15f, true },
                    { 4, "50 capsulas 500mg", 0f, "https://copservir.vtexassets.com/arquivos/ids/1027177-800-auto?v=638292281540200000&width=800&height=auto&aspect=true", 3, 1, 3, "Amoxicilina", 40f, true },
                    { 5, "10 tabletas 10mg", 0f, "https://copservir.vtexassets.com/arquivos/ids/989672-800-auto?v=638243980849430000&width=800&height=auto&aspect=true", 7, 1, 1, "Cetirizina", 10f, true },
                    { 6, "30 tabletas recubiertas de 50mg via oral", 0f, "https://pasteurio.vtexassets.com/arquivos/ids/174364/Salud-y-Medicamentos-Medicamentos-formulados_Genfar_Pasteur_134452_caja_01.jpg?v=638031144709070000", 7, 1, 1, "Losartan", 55f, true },
                    { 7, "30 tabletas de 850mg", 40f, "https://pymstatic.com/43895/conversions/metformina-wide.jpg", 2, 1, 1, "Metformina", 60f, true },
                    { 8, "30 tabletas recubiertas de 30mg", 12f, "https://www.farmalisto.com.co/154365/atorvastatina-10-mg-la-sante-caja-con-30-tabletas.jpg", 3, 1, 1, "Atorvastatina", 45f, true },
                    { 9, "30 tabletas recubiertas de 2mg", 0f, "https://farmastore.com.ve/192-large_default/sedatril-clonazepam-tq-2-mg-x-30-tabletas-rivotril.jpg", 1, 1, 1, "Clonazepam", 35f, true },
                    { 10, "5 mg / 5ml jarabe de 100ml", 0f, "https://www.drogueriasanjorge.com/wp-content/uploads/2012/03/7702605101641_A1N1_es_s01.jpg", 7, 2, 2, "Loratadina", 22f, true }
                });

            migrationBuilder.InsertData(
                table: "person",
                columns: new[] { "idPk", "birthdate", "DocumentNumber", "documentTypeIdFk", "Name", "personTypeIdFk", "registerdate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 26, 12, 49, 22, 78, DateTimeKind.Local).AddTicks(9491), "0000000000", 3, "root", 1, new DateTime(2023, 9, 26, 12, 49, 22, 78, DateTimeKind.Local).AddTicks(9457) },
                    { 2, new DateTime(2023, 9, 26, 12, 49, 22, 78, DateTimeKind.Local).AddTicks(9498), "0000000001", 3, "ProveedorA", 2, new DateTime(2023, 9, 26, 12, 49, 22, 78, DateTimeKind.Local).AddTicks(9497) },
                    { 3, new DateTime(2023, 9, 26, 12, 49, 22, 78, DateTimeKind.Local).AddTicks(9499), "0000000002", 3, "ProveedorB", 2, new DateTime(2023, 9, 26, 12, 49, 22, 78, DateTimeKind.Local).AddTicks(9498) },
                    { 4, new DateTime(2023, 9, 26, 12, 49, 22, 78, DateTimeKind.Local).AddTicks(9501), "0000000003", 3, "ProveedorC", 2, new DateTime(2023, 9, 26, 12, 49, 22, 78, DateTimeKind.Local).AddTicks(9500) },
                    { 5, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "546869433", 1, "Juan Paco", 1, new DateTime(2023, 9, 26, 12, 49, 22, 78, DateTimeKind.Local).AddTicks(9501) },
                    { 6, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "546869433", 1, "Pedro De La Mar", 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2014, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "1000354228", 2, "Maria Db", 1, new DateTime(2023, 9, 26, 12, 49, 22, 78, DateTimeKind.Local).AddTicks(9504) },
                    { 8, new DateTime(1929, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "555903923", 1, "Ana frank", 1, new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1978, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456789", 1, "Luis Fonsi", 1, new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1957, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "4355466753", 1, "Sena Sofia", 1, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1987, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "74328957843", 1, "Elena de avalord", 1, new DateTime(2001, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "city",
                columns: new[] { "id_city", "departamentIdFk", "name" },
                values: new object[,]
                {
                    { 1, 1, "Bucaramanga" },
                    { 2, 1, "Florida Blanca" },
                    { 3, 1, "San Gil" },
                    { 4, 1, "Barichara" }
                });

            migrationBuilder.InsertData(
                table: "contact",
                columns: new[] { "ContactCategoryIdFk", "contactTypeIdFk", "personIdFk", "description" },
                values: new object[,]
                {
                    { 1, 2, 2, "contacto@proveedor_a.com" },
                    { 1, 2, 3, "contacto@proveedor_b.com" },
                    { 1, 2, 4, "contacto@proveedor_c.com" }
                });

            migrationBuilder.InsertData(
                table: "employee",
                columns: new[] { "idPk", "chargeIdFk", "personIdFk" },
                values: new object[,]
                {
                    { 1, 1, 6 },
                    { 2, 1, 8 },
                    { 3, 2, 9 },
                    { 4, 3, 10 }
                });

            migrationBuilder.InsertData(
                table: "inventory",
                columns: new[] { "id", "location", "medicineInfoId" },
                values: new object[,]
                {
                    { 1, "A001", 1 },
                    { 2, "A002", 2 },
                    { 3, "C051", 3 },
                    { 4, "D221", 4 },
                    { 5, "Q011", 5 },
                    { 6, "C102", 6 },
                    { 7, "C101", 7 },
                    { 8, "D048", 8 },
                    { 9, "H048", 9 },
                    { 10, "H051", 10 }
                });

            migrationBuilder.InsertData(
                table: "supplier",
                columns: new[] { "idPk", "PersonId", "SupplierTypeId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 3, 2 },
                    { 3, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "idPk", "accessToken", "email", "password", "PersonId", "refreshToken", "username" },
                values: new object[] { 1, null, null, "root", 1, null, "root" });

            migrationBuilder.InsertData(
                table: "medicine",
                columns: new[] { "id", "creation_date", "expiration_date", "inventoryIdFk", "stateIdFk" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 2, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 4, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 5, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 6, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 7, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 8, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 9, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 10, new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 },
                    { 11, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 12, new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 13, new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 14, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 15, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 16, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 17, new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 18, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 19, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 20, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 21, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 22, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 23, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 24, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 25, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 26, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4 },
                    { 27, new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 28, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 29, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 30, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 31, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 32, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 33, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 34, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 35, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 36, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 37, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 38, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 39, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 40, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 41, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 42, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 43, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 44, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 45, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 46, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 47, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 48, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 49, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 50, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 51, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 52, new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 53, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 54, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 55, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 56, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 57, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 58, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 59, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 60, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 61, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 62, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 63, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 64, new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 65, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 66, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 67, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 68, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 69, new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 70, new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 71, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 72, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 73, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 74, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 75, new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 76, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 77, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 78, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 79, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 80, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 81, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 82, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 83, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 84, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 85, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 86, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 87, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 },
                    { 88, new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 89, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 90, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 91, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 92, new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 93, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 94, new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 95, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 96, new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 97, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 98, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 99, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 100, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 101, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 102, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 103, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 104, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 105, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 106, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 107, new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 108, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 109, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4 },
                    { 110, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 111, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 112, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 113, new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 114, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 115, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 116, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 117, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 118, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 119, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 120, new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 121, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 122, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 123, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 124, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 125, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 126, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 127, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4 },
                    { 128, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 129, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 130, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 131, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 132, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 133, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 134, new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 135, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4 },
                    { 136, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 137, new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 138, new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 139, new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 140, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 141, new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4 },
                    { 142, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 143, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 144, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 145, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 146, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 147, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 148, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 149, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 150, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 151, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 152, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 153, new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 154, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 155, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 156, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 157, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 158, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 159, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 160, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 161, new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 162, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 163, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 164, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 165, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 166, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 167, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 168, new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 169, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 170, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 171, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 172, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 173, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 174, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 175, new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 176, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 177, new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 178, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 179, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 180, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 181, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 182, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 183, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 184, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 185, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 186, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 187, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 188, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4 },
                    { 189, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 190, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 191, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 192, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4 },
                    { 193, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 194, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 195, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 196, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 197, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 198, new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 199, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 200, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "sale",
                columns: new[] { "idPk", "employeeId", "personId", "saledate" },
                values: new object[,]
                {
                    { 1, 1, 5, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, 6, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 6, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, 8, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 9, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 6, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, 10, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, 10, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, 7, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, 6, new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 10, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 3, 8, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 3, 9, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 3, 7, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, 7, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, 5, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "shopping",
                columns: new[] { "idPk", "employeeId", "shoppingDate", "supplierId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 2, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, 1, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 3, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, 1, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, 2, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, 1, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, 1, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, 1, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, 3, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, 1, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, 2, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, 2, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "shoppingDetail",
                columns: new[] { "MedicineId", "ShoppingId" },
                values: new object[,]
                {
                    { 110, 5 },
                    { 115, 10 },
                    { 121, 9 },
                    { 123, 4 },
                    { 123, 6 },
                    { 126, 3 },
                    { 127, 5 },
                    { 127, 6 },
                    { 129, 7 },
                    { 157, 15 },
                    { 160, 11 },
                    { 173, 10 },
                    { 174, 8 },
                    { 177, 7 },
                    { 178, 4 },
                    { 179, 13 },
                    { 181, 5 },
                    { 187, 15 },
                    { 192, 15 },
                    { 194, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_address_cityIdFk",
                table: "address",
                column: "cityIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_address_personIdFk",
                table: "address",
                column: "personIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_city_departamentIdFk",
                table: "city",
                column: "departamentIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_contact_ContactCategoryIdFk",
                table: "contact",
                column: "ContactCategoryIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_contact_contactTypeIdFk",
                table: "contact",
                column: "contactTypeIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_department_countryIdFk",
                table: "department",
                column: "countryIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_employee_chargeIdFk",
                table: "employee",
                column: "chargeIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_employee_personIdFk",
                table: "employee",
                column: "personIdFk",
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
                name: "IX_inventory_medicineInfoId",
                table: "inventory",
                column: "medicineInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_medicine_inventoryIdFk",
                table: "medicine",
                column: "inventoryIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_medicine_stateIdFk",
                table: "medicine",
                column: "stateIdFk");

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
                name: "IX_person_documentTypeIdFk",
                table: "person",
                column: "documentTypeIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_person_personTypeIdFk",
                table: "person",
                column: "personTypeIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_EpsId",
                table: "recipe",
                column: "EpsId");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_saleIdFk",
                table: "recipe",
                column: "saleIdFk");

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
                name: "medicine");

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
                name: "inventory");

            migrationBuilder.DropTable(
                name: "state");

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
                name: "medicinepresentation");

            migrationBuilder.DropTable(
                name: "documenttype");

            migrationBuilder.DropTable(
                name: "persontype");
        }
    }
}
