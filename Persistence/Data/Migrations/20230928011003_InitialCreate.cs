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
                    { 1, new DateTime(2023, 9, 27, 20, 10, 2, 971, DateTimeKind.Local).AddTicks(4507), "0000000000", 3, "root", 1, new DateTime(2023, 9, 27, 20, 10, 2, 971, DateTimeKind.Local).AddTicks(4483) },
                    { 2, new DateTime(2023, 9, 27, 20, 10, 2, 971, DateTimeKind.Local).AddTicks(4516), "0000000001", 3, "ProveedorA", 2, new DateTime(2023, 9, 27, 20, 10, 2, 971, DateTimeKind.Local).AddTicks(4515) },
                    { 3, new DateTime(2023, 9, 27, 20, 10, 2, 971, DateTimeKind.Local).AddTicks(4520), "0000000002", 3, "ProveedorB", 2, new DateTime(2023, 9, 27, 20, 10, 2, 971, DateTimeKind.Local).AddTicks(4519) },
                    { 4, new DateTime(2023, 9, 27, 20, 10, 2, 971, DateTimeKind.Local).AddTicks(4524), "0000000003", 3, "ProveedorC", 2, new DateTime(2023, 9, 27, 20, 10, 2, 971, DateTimeKind.Local).AddTicks(4523) },
                    { 5, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "546869433", 1, "Juan Paco", 1, new DateTime(2023, 9, 27, 20, 10, 2, 971, DateTimeKind.Local).AddTicks(4526) },
                    { 6, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "546869433", 1, "Pedro De La Mar", 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2014, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "1000354228", 2, "Maria Db", 1, new DateTime(2023, 9, 27, 20, 10, 2, 971, DateTimeKind.Local).AddTicks(4540) },
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
                    { 1, new DateTime(2023, 2, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4341), new DateTime(2026, 3, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4523), 6, 3 },
                    { 2, new DateTime(2023, 2, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4536), new DateTime(2025, 9, 6, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4539), 8, 2 },
                    { 3, new DateTime(2022, 12, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4544), new DateTime(2023, 12, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4547), 6, 4 },
                    { 4, new DateTime(2023, 4, 2, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 10, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4553), 3, 3 },
                    { 5, new DateTime(2023, 5, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4557), new DateTime(2025, 4, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4559), 1, 4 },
                    { 6, new DateTime(2023, 9, 11, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4587), new DateTime(2025, 11, 2, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4590), 3, 1 },
                    { 7, new DateTime(2022, 11, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4595), new DateTime(2026, 7, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4598), 8, 2 },
                    { 8, new DateTime(2022, 5, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 10, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4606), 9, 3 },
                    { 9, new DateTime(2022, 11, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 10, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4613), 7, 1 },
                    { 10, new DateTime(2022, 10, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 3, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4621), 3, 3 },
                    { 11, new DateTime(2022, 9, 14, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4626), new DateTime(2026, 7, 30, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4628), 2, 2 },
                    { 12, new DateTime(2022, 7, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4632), new DateTime(2026, 8, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4634), 7, 3 },
                    { 13, new DateTime(2022, 3, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4639), new DateTime(2025, 11, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4641), 6, 3 },
                    { 14, new DateTime(2023, 2, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4656), new DateTime(2026, 8, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4659), 2, 3 },
                    { 15, new DateTime(2023, 1, 4, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 8, 12, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4676), 6, 4 },
                    { 16, new DateTime(2022, 8, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4719), new DateTime(2026, 3, 22, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4723), 1, 3 },
                    { 17, new DateTime(2022, 11, 4, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4727), new DateTime(2025, 11, 12, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4730), 4, 4 },
                    { 18, new DateTime(2022, 7, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 7, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4738), 4, 4 },
                    { 19, new DateTime(2022, 10, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4742), new DateTime(2024, 5, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4744), 7, 2 },
                    { 20, new DateTime(2022, 9, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 6, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4751), 7, 1 },
                    { 21, new DateTime(2022, 3, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4776), new DateTime(2026, 9, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4779), 1, 3 },
                    { 22, new DateTime(2022, 4, 18, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4785), new DateTime(2025, 7, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4788), 4, 2 },
                    { 23, new DateTime(2022, 11, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4792), new DateTime(2025, 11, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4795), 6, 2 },
                    { 24, new DateTime(2022, 7, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4798), new DateTime(2026, 5, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4800), 1, 4 },
                    { 25, new DateTime(2023, 5, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 8, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4807), 4, 2 },
                    { 26, new DateTime(2023, 1, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4811), new DateTime(2025, 12, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4813), 7, 1 },
                    { 27, new DateTime(2023, 3, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4818), new DateTime(2025, 7, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4821), 6, 1 },
                    { 28, new DateTime(2022, 6, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4826), new DateTime(2024, 1, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4828), 8, 3 },
                    { 29, new DateTime(2023, 3, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4833), new DateTime(2023, 11, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4835), 7, 4 },
                    { 30, new DateTime(2022, 10, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4839), new DateTime(2026, 4, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4848), 2, 1 },
                    { 31, new DateTime(2022, 11, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 6, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4861), 8, 2 },
                    { 32, new DateTime(2023, 2, 12, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4864), new DateTime(2026, 5, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4867), 2, 4 },
                    { 33, new DateTime(2023, 1, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4871), new DateTime(2025, 9, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4875), 5, 3 },
                    { 34, new DateTime(2023, 6, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 6, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4883), 5, 2 },
                    { 35, new DateTime(2022, 8, 11, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4888), new DateTime(2024, 10, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4891), 5, 3 },
                    { 36, new DateTime(2023, 3, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4894), new DateTime(2026, 4, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4897), 6, 3 },
                    { 37, new DateTime(2022, 11, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4901), new DateTime(2026, 4, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4903), 7, 4 },
                    { 38, new DateTime(2023, 2, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4906), new DateTime(2025, 8, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4908), 9, 4 },
                    { 39, new DateTime(2022, 10, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4911), new DateTime(2025, 6, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4914), 6, 4 },
                    { 40, new DateTime(2023, 7, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4919), new DateTime(2025, 11, 21, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4922), 9, 3 },
                    { 41, new DateTime(2022, 9, 4, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4925), new DateTime(2025, 8, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4928), 2, 3 },
                    { 42, new DateTime(2023, 2, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4931), new DateTime(2024, 5, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4933), 2, 1 },
                    { 43, new DateTime(2022, 8, 2, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4938), new DateTime(2023, 11, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4940), 1, 4 },
                    { 44, new DateTime(2021, 12, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4944), new DateTime(2026, 9, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4946), 3, 3 },
                    { 45, new DateTime(2023, 1, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4950), new DateTime(2025, 12, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4953), 8, 3 },
                    { 46, new DateTime(2022, 4, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4957), new DateTime(2024, 12, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4960), 6, 4 },
                    { 47, new DateTime(2023, 3, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 1, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4967), 4, 2 },
                    { 48, new DateTime(2022, 9, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4971), new DateTime(2023, 12, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4975), 7, 3 },
                    { 49, new DateTime(2023, 4, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4980), new DateTime(2025, 7, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4983), 4, 4 },
                    { 50, new DateTime(2022, 6, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 3, 21, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4990), 4, 3 },
                    { 51, new DateTime(2022, 7, 4, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4993), new DateTime(2026, 1, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(4996), 4, 4 },
                    { 52, new DateTime(2022, 12, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5000), new DateTime(2026, 9, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5003), 6, 3 },
                    { 53, new DateTime(2022, 4, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5007), new DateTime(2025, 4, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5010), 8, 2 },
                    { 54, new DateTime(2022, 12, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5015), new DateTime(2024, 9, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5018), 2, 3 },
                    { 55, new DateTime(2022, 7, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5022), new DateTime(2025, 5, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5025), 7, 4 },
                    { 56, new DateTime(2021, 12, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5028), new DateTime(2025, 7, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5031), 7, 1 },
                    { 57, new DateTime(2023, 2, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5034), new DateTime(2026, 2, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5038), 9, 3 },
                    { 58, new DateTime(2023, 1, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5041), new DateTime(2024, 4, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5044), 7, 3 },
                    { 59, new DateTime(2022, 9, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5048), new DateTime(2024, 3, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5051), 5, 2 },
                    { 60, new DateTime(2023, 1, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5055), new DateTime(2026, 8, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5057), 7, 1 },
                    { 61, new DateTime(2023, 9, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5062), new DateTime(2025, 6, 6, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5065), 8, 1 },
                    { 62, new DateTime(2022, 5, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5068), new DateTime(2024, 8, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5070), 6, 1 },
                    { 63, new DateTime(2022, 11, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5073), new DateTime(2025, 12, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5076), 1, 2 },
                    { 64, new DateTime(2023, 1, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5079), new DateTime(2025, 4, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5081), 1, 2 },
                    { 65, new DateTime(2023, 4, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5084), new DateTime(2025, 12, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5087), 6, 3 },
                    { 66, new DateTime(2022, 9, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5092), new DateTime(2024, 1, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5095), 1, 4 },
                    { 67, new DateTime(2023, 8, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5099), new DateTime(2025, 10, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5101), 8, 4 },
                    { 68, new DateTime(2023, 6, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5105), new DateTime(2024, 7, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5107), 4, 3 },
                    { 69, new DateTime(2023, 3, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5112), new DateTime(2026, 5, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5114), 8, 2 },
                    { 70, new DateTime(2023, 3, 6, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5117), new DateTime(2026, 3, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5120), 7, 2 },
                    { 71, new DateTime(2022, 12, 18, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5123), new DateTime(2026, 9, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5125), 6, 4 },
                    { 72, new DateTime(2022, 6, 14, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5129), new DateTime(2023, 10, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5132), 2, 1 },
                    { 73, new DateTime(2022, 10, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5135), new DateTime(2024, 10, 30, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5138), 1, 2 },
                    { 74, new DateTime(2022, 4, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 11, 22, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5145), 4, 3 },
                    { 75, new DateTime(2022, 11, 4, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5148), new DateTime(2025, 4, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5151), 7, 2 },
                    { 76, new DateTime(2022, 11, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5155), new DateTime(2024, 8, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5157), 3, 1 },
                    { 77, new DateTime(2022, 9, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5160), new DateTime(2025, 12, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5163), 9, 4 },
                    { 78, new DateTime(2023, 3, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5166), new DateTime(2025, 3, 31, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5169), 1, 4 },
                    { 79, new DateTime(2022, 10, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5173), new DateTime(2023, 10, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5175), 7, 4 },
                    { 80, new DateTime(2021, 12, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5178), new DateTime(2024, 5, 12, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5180), 1, 4 },
                    { 81, new DateTime(2022, 9, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5184), new DateTime(2023, 10, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5187), 4, 3 },
                    { 82, new DateTime(2022, 4, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5191), new DateTime(2024, 11, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5193), 7, 1 },
                    { 83, new DateTime(2023, 6, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5197), new DateTime(2024, 1, 18, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5200), 8, 2 },
                    { 84, new DateTime(2022, 8, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5204), new DateTime(2025, 2, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5206), 9, 3 },
                    { 85, new DateTime(2022, 12, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5210), new DateTime(2026, 9, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5213), 8, 4 },
                    { 86, new DateTime(2022, 1, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5217), new DateTime(2024, 11, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5219), 6, 1 },
                    { 87, new DateTime(2022, 7, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5222), new DateTime(2024, 7, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5225), 2, 1 },
                    { 88, new DateTime(2022, 12, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5229), new DateTime(2025, 4, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5231), 2, 3 },
                    { 89, new DateTime(2022, 7, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5248), new DateTime(2026, 1, 30, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5250), 6, 1 },
                    { 90, new DateTime(2023, 6, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 5, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5256), 2, 3 },
                    { 91, new DateTime(2022, 6, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5259), new DateTime(2025, 9, 12, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5262), 6, 2 },
                    { 92, new DateTime(2022, 2, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5265), new DateTime(2026, 8, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5268), 5, 1 },
                    { 93, new DateTime(2022, 12, 4, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5272), new DateTime(2025, 9, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5274), 3, 4 },
                    { 94, new DateTime(2022, 3, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5278), new DateTime(2025, 1, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5280), 1, 4 },
                    { 95, new DateTime(2021, 12, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5284), new DateTime(2026, 8, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5286), 9, 3 },
                    { 96, new DateTime(2023, 7, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5290), new DateTime(2025, 3, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5293), 2, 3 },
                    { 97, new DateTime(2022, 10, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5295), new DateTime(2026, 4, 18, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5298), 9, 4 },
                    { 98, new DateTime(2022, 8, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5302), new DateTime(2026, 1, 11, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5305), 6, 4 },
                    { 99, new DateTime(2022, 6, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5309), new DateTime(2026, 5, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5311), 9, 2 },
                    { 100, new DateTime(2023, 3, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 4, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5316), 4, 1 },
                    { 101, new DateTime(2023, 4, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5321), new DateTime(2024, 5, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5324), 1, 3 },
                    { 102, new DateTime(2023, 2, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5328), new DateTime(2025, 8, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5330), 5, 2 },
                    { 103, new DateTime(2023, 3, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 4, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5336), 5, 1 },
                    { 104, new DateTime(2023, 6, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5339), new DateTime(2026, 4, 6, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5342), 1, 2 },
                    { 105, new DateTime(2023, 5, 14, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5345), new DateTime(2026, 3, 22, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5348), 9, 3 },
                    { 106, new DateTime(2022, 8, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5352), new DateTime(2026, 8, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5355), 4, 3 },
                    { 107, new DateTime(2022, 6, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5358), new DateTime(2024, 3, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5361), 8, 3 },
                    { 108, new DateTime(2021, 12, 14, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5364), new DateTime(2024, 5, 11, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5368), 8, 3 },
                    { 109, new DateTime(2022, 10, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5372), new DateTime(2023, 10, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5374), 6, 3 },
                    { 110, new DateTime(2022, 10, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5377), new DateTime(2025, 7, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5380), 8, 3 },
                    { 111, new DateTime(2023, 2, 21, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5383), new DateTime(2026, 3, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5385), 5, 1 },
                    { 112, new DateTime(2022, 7, 2, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5389), new DateTime(2023, 11, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5392), 9, 1 },
                    { 113, new DateTime(2023, 4, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5395), new DateTime(2024, 5, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5397), 5, 4 },
                    { 114, new DateTime(2022, 3, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5401), new DateTime(2025, 6, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5404), 9, 3 },
                    { 115, new DateTime(2023, 6, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5407), new DateTime(2026, 8, 31, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5409), 9, 1 },
                    { 116, new DateTime(2022, 12, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5412), new DateTime(2025, 4, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5415), 5, 2 },
                    { 117, new DateTime(2023, 2, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5418), new DateTime(2024, 6, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5420), 4, 1 },
                    { 118, new DateTime(2022, 8, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5424), new DateTime(2024, 7, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5427), 6, 2 },
                    { 119, new DateTime(2022, 8, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5430), new DateTime(2025, 9, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5433), 9, 3 },
                    { 120, new DateTime(2022, 9, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5436), new DateTime(2026, 9, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5438), 2, 1 },
                    { 121, new DateTime(2022, 9, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5442), new DateTime(2024, 6, 2, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5444), 6, 1 },
                    { 122, new DateTime(2022, 5, 6, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5447), new DateTime(2024, 8, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5450), 5, 3 },
                    { 123, new DateTime(2022, 4, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5454), new DateTime(2026, 4, 30, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5456), 9, 2 },
                    { 124, new DateTime(2023, 6, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5459), new DateTime(2025, 7, 18, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5461), 1, 4 },
                    { 125, new DateTime(2022, 9, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5465), new DateTime(2026, 6, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5467), 2, 3 },
                    { 126, new DateTime(2022, 7, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5471), new DateTime(2025, 7, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5474), 6, 4 },
                    { 127, new DateTime(2022, 3, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5477), new DateTime(2025, 6, 11, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5480), 5, 4 },
                    { 128, new DateTime(2022, 11, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5482), new DateTime(2024, 4, 4, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5486), 3, 4 },
                    { 129, new DateTime(2022, 5, 1, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5489), new DateTime(2025, 11, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5491), 4, 4 },
                    { 130, new DateTime(2022, 6, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5497), new DateTime(2026, 8, 11, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5500), 5, 4 },
                    { 131, new DateTime(2023, 2, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5504), new DateTime(2026, 4, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5506), 5, 1 },
                    { 132, new DateTime(2023, 1, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 10, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5512), 6, 3 },
                    { 133, new DateTime(2022, 4, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5516), new DateTime(2026, 7, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5518), 7, 3 },
                    { 134, new DateTime(2022, 11, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5521), new DateTime(2023, 10, 6, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5524), 5, 1 },
                    { 135, new DateTime(2022, 4, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5527), new DateTime(2024, 7, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5530), 3, 3 },
                    { 136, new DateTime(2023, 2, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5535), new DateTime(2024, 11, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5537), 6, 1 },
                    { 137, new DateTime(2022, 10, 12, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5540), new DateTime(2026, 4, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5543), 7, 2 },
                    { 138, new DateTime(2022, 1, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5547), new DateTime(2024, 6, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5550), 3, 1 },
                    { 139, new DateTime(2022, 1, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5554), new DateTime(2025, 11, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5556), 5, 1 },
                    { 140, new DateTime(2022, 10, 6, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5559), new DateTime(2025, 7, 31, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5562), 5, 3 },
                    { 141, new DateTime(2023, 3, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5564), new DateTime(2026, 6, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5567), 7, 2 },
                    { 142, new DateTime(2023, 3, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5570), new DateTime(2026, 8, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5572), 4, 3 },
                    { 143, new DateTime(2023, 7, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 11, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5577), 3, 1 },
                    { 144, new DateTime(2022, 12, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5579), new DateTime(2025, 5, 30, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5582), 2, 2 },
                    { 145, new DateTime(2022, 10, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5584), new DateTime(2025, 7, 30, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5586), 7, 3 },
                    { 146, new DateTime(2022, 10, 11, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5589), new DateTime(2024, 10, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5591), 3, 3 },
                    { 147, new DateTime(2022, 12, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5595), new DateTime(2024, 2, 21, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5598), 9, 1 },
                    { 148, new DateTime(2022, 11, 22, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5601), new DateTime(2025, 8, 22, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5604), 9, 3 },
                    { 149, new DateTime(2022, 2, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5608), new DateTime(2024, 8, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5610), 2, 2 },
                    { 150, new DateTime(2022, 6, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 6, 30, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5616), 2, 2 },
                    { 151, new DateTime(2022, 10, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5621), new DateTime(2023, 10, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5624), 5, 1 },
                    { 152, new DateTime(2022, 5, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5626), new DateTime(2026, 3, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5629), 6, 1 },
                    { 153, new DateTime(2022, 9, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5646), new DateTime(2025, 1, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5648), 6, 4 },
                    { 154, new DateTime(2022, 10, 12, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5653), new DateTime(2025, 10, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5656), 9, 3 },
                    { 155, new DateTime(2022, 6, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5659), new DateTime(2025, 11, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5662), 2, 4 },
                    { 156, new DateTime(2023, 2, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5665), new DateTime(2026, 7, 18, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5668), 9, 2 },
                    { 157, new DateTime(2022, 2, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5671), new DateTime(2025, 5, 11, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5674), 8, 3 },
                    { 158, new DateTime(2023, 7, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5677), new DateTime(2023, 12, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5680), 8, 1 },
                    { 159, new DateTime(2023, 5, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5683), new DateTime(2025, 12, 31, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5685), 1, 1 },
                    { 160, new DateTime(2023, 1, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5688), new DateTime(2026, 4, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5691), 5, 3 },
                    { 161, new DateTime(2022, 9, 18, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5695), new DateTime(2024, 4, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5697), 4, 4 },
                    { 162, new DateTime(2022, 12, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 11, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5704), 1, 1 },
                    { 163, new DateTime(2023, 3, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5707), new DateTime(2024, 4, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5709), 9, 3 },
                    { 164, new DateTime(2023, 5, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5712), new DateTime(2026, 8, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5715), 8, 1 },
                    { 165, new DateTime(2023, 1, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5718), new DateTime(2025, 6, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5721), 7, 4 },
                    { 166, new DateTime(2022, 4, 27, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5724), new DateTime(2025, 10, 30, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5727), 3, 2 },
                    { 167, new DateTime(2022, 9, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 8, 22, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5734), 6, 4 },
                    { 168, new DateTime(2022, 8, 22, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5739), new DateTime(2025, 6, 4, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5741), 1, 3 },
                    { 169, new DateTime(2022, 8, 2, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5745), new DateTime(2026, 1, 21, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5748), 4, 2 },
                    { 170, new DateTime(2022, 8, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 8, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5754), 6, 4 },
                    { 171, new DateTime(2022, 9, 2, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5758), new DateTime(2023, 12, 12, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5760), 8, 1 },
                    { 172, new DateTime(2023, 7, 21, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5764), new DateTime(2023, 12, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5766), 8, 1 },
                    { 173, new DateTime(2022, 4, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5769), new DateTime(2025, 7, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5773), 3, 3 },
                    { 174, new DateTime(2022, 10, 5, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5777), new DateTime(2025, 2, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5780), 7, 4 },
                    { 175, new DateTime(2023, 8, 21, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5784), new DateTime(2026, 7, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5786), 1, 4 },
                    { 176, new DateTime(2022, 4, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5789), new DateTime(2026, 7, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5791), 3, 2 },
                    { 177, new DateTime(2022, 7, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5794), new DateTime(2025, 2, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5797), 6, 2 },
                    { 178, new DateTime(2022, 5, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5801), new DateTime(2025, 10, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5803), 1, 1 },
                    { 179, new DateTime(2022, 12, 3, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5806), new DateTime(2025, 3, 22, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5808), 1, 4 },
                    { 180, new DateTime(2022, 5, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5811), new DateTime(2025, 4, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5813), 1, 3 },
                    { 181, new DateTime(2022, 8, 22, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5816), new DateTime(2025, 7, 14, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5819), 9, 2 },
                    { 182, new DateTime(2022, 12, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5822), new DateTime(2025, 4, 21, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5824), 5, 1 },
                    { 183, new DateTime(2022, 11, 11, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5828), new DateTime(2026, 7, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5830), 5, 2 },
                    { 184, new DateTime(2022, 11, 9, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5833), new DateTime(2024, 12, 12, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5837), 6, 4 },
                    { 185, new DateTime(2023, 6, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5841), new DateTime(2024, 2, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5843), 7, 4 },
                    { 186, new DateTime(2022, 11, 21, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5848), new DateTime(2024, 4, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5850), 7, 3 },
                    { 187, new DateTime(2022, 10, 31, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5854), new DateTime(2023, 12, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5856), 9, 1 },
                    { 188, new DateTime(2022, 8, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5860), new DateTime(2024, 11, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5863), 9, 4 },
                    { 189, new DateTime(2022, 7, 4, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5867), new DateTime(2026, 3, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5869), 4, 2 },
                    { 190, new DateTime(2022, 12, 28, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 10, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5875), 3, 1 },
                    { 191, new DateTime(2023, 4, 20, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5878), new DateTime(2024, 8, 17, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5880), 3, 1 },
                    { 192, new DateTime(2023, 1, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5885), new DateTime(2023, 11, 26, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5887), 6, 1 },
                    { 193, new DateTime(2022, 1, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5890), new DateTime(2026, 3, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5892), 4, 4 },
                    { 194, new DateTime(2022, 5, 29, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5895), new DateTime(2023, 11, 19, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5898), 4, 4 },
                    { 195, new DateTime(2022, 8, 10, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 10, 7, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5904), 2, 1 },
                    { 196, new DateTime(2022, 3, 11, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5908), new DateTime(2025, 12, 31, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5911), 2, 2 },
                    { 197, new DateTime(2022, 8, 25, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5916), new DateTime(2024, 5, 13, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5918), 7, 2 },
                    { 198, new DateTime(2022, 7, 23, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5921), new DateTime(2025, 6, 16, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5924), 2, 4 },
                    { 199, new DateTime(2023, 1, 24, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 11, 8, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5931), 2, 3 },
                    { 200, new DateTime(2023, 2, 15, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5934), new DateTime(2026, 1, 4, 20, 10, 2, 967, DateTimeKind.Local).AddTicks(5937), 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "sale",
                columns: new[] { "idPk", "employeeId", "personId", "saledate" },
                values: new object[,]
                {
                    { 1, 2, 6, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 10, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, 9, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, 7, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 8, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 10, new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, 10, new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 7, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, 6, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, 7, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 10, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, 5, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 3, 5, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 3, 5, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, 7, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 2, 9, new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "shopping",
                columns: new[] { "idPk", "employeeId", "shoppingDate", "supplierId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 2, 2, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 1, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, 2, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 1, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, 2, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, 2, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, 1, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, 1, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, 3, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, 3, new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, 2, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, 3, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, 2, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "saleDetail",
                columns: new[] { "MedicineId", "SaleId" },
                values: new object[,]
                {
                    { 1, 13 },
                    { 2, 13 },
                    { 3, 9 },
                    { 4, 9 },
                    { 5, 10 },
                    { 6, 7 },
                    { 7, 5 },
                    { 8, 7 },
                    { 9, 11 },
                    { 10, 13 },
                    { 11, 14 },
                    { 12, 10 },
                    { 13, 8 },
                    { 14, 15 },
                    { 15, 11 },
                    { 16, 7 },
                    { 17, 8 },
                    { 18, 4 },
                    { 19, 2 },
                    { 20, 11 },
                    { 21, 13 },
                    { 22, 15 },
                    { 23, 13 },
                    { 24, 12 },
                    { 25, 7 },
                    { 26, 2 },
                    { 27, 2 },
                    { 28, 13 },
                    { 29, 11 },
                    { 30, 5 },
                    { 31, 11 },
                    { 32, 11 },
                    { 33, 6 },
                    { 34, 5 },
                    { 35, 12 },
                    { 36, 12 },
                    { 37, 3 },
                    { 38, 15 },
                    { 39, 3 },
                    { 40, 8 },
                    { 41, 15 },
                    { 42, 6 },
                    { 43, 10 },
                    { 44, 9 },
                    { 45, 14 },
                    { 46, 4 },
                    { 47, 14 },
                    { 48, 9 },
                    { 49, 1 },
                    { 50, 15 },
                    { 51, 14 },
                    { 52, 5 },
                    { 53, 1 },
                    { 54, 5 },
                    { 55, 6 },
                    { 56, 8 },
                    { 57, 12 },
                    { 58, 15 },
                    { 59, 13 },
                    { 60, 11 },
                    { 61, 7 },
                    { 62, 14 },
                    { 63, 10 },
                    { 64, 7 },
                    { 65, 10 },
                    { 66, 9 },
                    { 67, 10 },
                    { 68, 3 },
                    { 69, 11 },
                    { 70, 4 },
                    { 71, 8 },
                    { 72, 12 },
                    { 73, 8 },
                    { 74, 9 },
                    { 75, 14 },
                    { 76, 2 },
                    { 77, 4 },
                    { 78, 11 },
                    { 79, 14 },
                    { 80, 7 },
                    { 81, 9 },
                    { 82, 11 },
                    { 83, 15 },
                    { 84, 3 },
                    { 85, 11 },
                    { 86, 11 },
                    { 87, 14 },
                    { 88, 13 },
                    { 89, 3 },
                    { 90, 12 },
                    { 91, 7 },
                    { 92, 1 },
                    { 93, 1 },
                    { 94, 6 },
                    { 95, 7 },
                    { 96, 7 },
                    { 97, 3 },
                    { 98, 4 },
                    { 99, 8 }
                });

            migrationBuilder.InsertData(
                table: "shoppingDetail",
                columns: new[] { "MedicineId", "ShoppingId" },
                values: new object[,]
                {
                    { 101, 14 },
                    { 102, 14 },
                    { 103, 6 },
                    { 104, 10 },
                    { 105, 11 },
                    { 106, 5 },
                    { 107, 4 },
                    { 108, 14 },
                    { 109, 9 },
                    { 110, 1 },
                    { 111, 13 },
                    { 112, 10 },
                    { 113, 2 },
                    { 114, 7 },
                    { 115, 11 },
                    { 116, 5 },
                    { 117, 7 },
                    { 118, 14 },
                    { 119, 9 },
                    { 120, 9 },
                    { 121, 5 },
                    { 122, 13 },
                    { 123, 3 },
                    { 124, 11 },
                    { 125, 13 },
                    { 126, 12 },
                    { 127, 12 },
                    { 128, 13 },
                    { 129, 6 },
                    { 130, 12 },
                    { 131, 7 },
                    { 132, 14 },
                    { 133, 3 },
                    { 134, 9 },
                    { 135, 1 },
                    { 136, 12 },
                    { 137, 15 },
                    { 138, 8 },
                    { 139, 15 },
                    { 140, 13 },
                    { 141, 7 },
                    { 142, 10 },
                    { 143, 7 },
                    { 144, 12 },
                    { 145, 9 },
                    { 146, 5 },
                    { 147, 8 },
                    { 148, 10 },
                    { 149, 8 },
                    { 150, 15 },
                    { 151, 14 },
                    { 152, 14 },
                    { 153, 15 },
                    { 154, 13 },
                    { 155, 9 },
                    { 156, 7 },
                    { 157, 4 },
                    { 158, 5 },
                    { 159, 11 },
                    { 160, 9 },
                    { 161, 14 },
                    { 162, 11 },
                    { 163, 6 },
                    { 164, 12 },
                    { 165, 12 },
                    { 166, 10 },
                    { 167, 6 },
                    { 168, 15 },
                    { 169, 1 },
                    { 170, 8 },
                    { 171, 15 },
                    { 172, 1 },
                    { 173, 11 },
                    { 174, 3 },
                    { 175, 11 },
                    { 176, 15 },
                    { 177, 6 },
                    { 178, 8 },
                    { 179, 4 },
                    { 180, 10 },
                    { 181, 1 },
                    { 182, 8 },
                    { 183, 2 },
                    { 184, 12 },
                    { 185, 7 },
                    { 186, 12 },
                    { 187, 15 },
                    { 188, 2 },
                    { 189, 2 },
                    { 190, 8 },
                    { 191, 7 },
                    { 192, 12 },
                    { 193, 9 },
                    { 194, 5 },
                    { 195, 5 },
                    { 196, 9 },
                    { 197, 7 },
                    { 198, 2 },
                    { 199, 4 }
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
