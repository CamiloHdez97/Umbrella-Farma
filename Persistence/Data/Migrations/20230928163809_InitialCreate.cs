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
                    { 4, "sold" }
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
                    { 1, new DateTime(2023, 9, 28, 11, 38, 9, 262, DateTimeKind.Local).AddTicks(4), "0000000000", 3, "root", 1, new DateTime(2023, 9, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(9995) },
                    { 2, new DateTime(2023, 9, 28, 11, 38, 9, 262, DateTimeKind.Local).AddTicks(11), "0000000001", 3, "ProveedorA", 2, new DateTime(2023, 9, 28, 11, 38, 9, 262, DateTimeKind.Local).AddTicks(10) },
                    { 3, new DateTime(2023, 9, 28, 11, 38, 9, 262, DateTimeKind.Local).AddTicks(12), "0000000002", 3, "ProveedorB", 2, new DateTime(2023, 9, 28, 11, 38, 9, 262, DateTimeKind.Local).AddTicks(11) },
                    { 4, new DateTime(2023, 9, 28, 11, 38, 9, 262, DateTimeKind.Local).AddTicks(14), "0000000003", 3, "ProveedorC", 2, new DateTime(2023, 9, 28, 11, 38, 9, 262, DateTimeKind.Local).AddTicks(13) },
                    { 5, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "546869433", 1, "Juan Paco", 1, new DateTime(2023, 9, 28, 11, 38, 9, 262, DateTimeKind.Local).AddTicks(14) },
                    { 6, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "546869433", 1, "Pedro De La Mar", 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2014, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "1000354228", 2, "Maria Db", 1, new DateTime(2023, 9, 28, 11, 38, 9, 262, DateTimeKind.Local).AddTicks(19) },
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
                    { 1, new DateTime(2022, 12, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8875), new DateTime(2025, 1, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8930), 5, 4 },
                    { 2, new DateTime(2022, 7, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8961), new DateTime(2022, 6, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8962), 4, 2 },
                    { 3, new DateTime(2023, 5, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8965), new DateTime(2024, 8, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8966), 7, 3 },
                    { 4, new DateTime(2022, 9, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8970), new DateTime(2024, 12, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8971), 6, 4 },
                    { 5, new DateTime(2022, 10, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8974), new DateTime(2024, 11, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8975), 4, 4 },
                    { 6, new DateTime(2022, 7, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8978), new DateTime(2025, 4, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8979), 5, 4 },
                    { 7, new DateTime(2022, 11, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8982), new DateTime(2024, 10, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8982), 1, 3 },
                    { 8, new DateTime(2022, 12, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8985), new DateTime(2022, 12, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8986), 6, 2 },
                    { 9, new DateTime(2022, 10, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8988), new DateTime(2023, 11, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8989), 2, 3 },
                    { 10, new DateTime(2023, 4, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8992), new DateTime(2024, 6, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8993), 5, 4 },
                    { 11, new DateTime(2022, 9, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8995), new DateTime(2025, 1, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8996), 2, 4 },
                    { 12, new DateTime(2021, 12, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8998), new DateTime(2025, 2, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(8999), 9, 4 },
                    { 13, new DateTime(2022, 10, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9001), new DateTime(2025, 3, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9002), 1, 4 },
                    { 14, new DateTime(2022, 6, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 4, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9005), 2, 4 },
                    { 15, new DateTime(2022, 9, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9007), new DateTime(2024, 1, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9009), 7, 3 },
                    { 16, new DateTime(2022, 10, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9011), new DateTime(2024, 8, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9012), 6, 4 },
                    { 17, new DateTime(2022, 9, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9014), new DateTime(2024, 10, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9015), 2, 4 },
                    { 18, new DateTime(2022, 4, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9018), new DateTime(2024, 2, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9019), 2, 4 },
                    { 19, new DateTime(2022, 12, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9021), new DateTime(2025, 7, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9022), 9, 4 },
                    { 20, new DateTime(2023, 6, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9025), new DateTime(2024, 7, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9026), 4, 4 },
                    { 21, new DateTime(2022, 10, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9028), new DateTime(2024, 4, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9029), 1, 4 },
                    { 22, new DateTime(2022, 8, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9031), new DateTime(2024, 9, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9032), 2, 3 },
                    { 23, new DateTime(2022, 6, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9035), new DateTime(2024, 5, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9036), 6, 4 },
                    { 24, new DateTime(2023, 1, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9038), new DateTime(2022, 9, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9039), 5, 2 },
                    { 25, new DateTime(2023, 1, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9041), new DateTime(2023, 12, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9042), 1, 4 },
                    { 26, new DateTime(2022, 11, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9044), new DateTime(2024, 2, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9045), 2, 4 },
                    { 27, new DateTime(2022, 9, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9047), new DateTime(2022, 1, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9048), 6, 2 },
                    { 28, new DateTime(2022, 6, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9051), new DateTime(2025, 4, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9052), 7, 4 },
                    { 29, new DateTime(2022, 5, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 5, 31, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9090), 4, 4 },
                    { 30, new DateTime(2022, 12, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9092), new DateTime(2025, 3, 31, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9093), 9, 4 },
                    { 31, new DateTime(2022, 8, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9095), new DateTime(2023, 12, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9096), 3, 4 },
                    { 32, new DateTime(2022, 1, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9098), new DateTime(2024, 11, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9099), 9, 3 },
                    { 33, new DateTime(2022, 8, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9101), new DateTime(2024, 9, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9102), 3, 4 },
                    { 34, new DateTime(2022, 6, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9105), new DateTime(2025, 4, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9106), 1, 3 },
                    { 35, new DateTime(2023, 1, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9108), new DateTime(2024, 6, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9109), 7, 4 },
                    { 36, new DateTime(2022, 9, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9111), new DateTime(2024, 6, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9112), 1, 4 },
                    { 37, new DateTime(2022, 12, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9114), new DateTime(2025, 1, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9115), 8, 3 },
                    { 38, new DateTime(2023, 5, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 10, 31, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9118), 8, 4 },
                    { 39, new DateTime(2023, 2, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9120), new DateTime(2025, 1, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9121), 9, 4 },
                    { 40, new DateTime(2023, 4, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9123), new DateTime(2025, 1, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9124), 7, 4 },
                    { 41, new DateTime(2023, 1, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9126), new DateTime(2025, 2, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9127), 5, 4 },
                    { 42, new DateTime(2022, 10, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 11, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9130), 7, 4 },
                    { 43, new DateTime(2022, 11, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9132), new DateTime(2023, 12, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9133), 3, 4 },
                    { 44, new DateTime(2022, 10, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9135), new DateTime(2025, 4, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9136), 1, 4 },
                    { 45, new DateTime(2023, 1, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9138), new DateTime(2024, 6, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9139), 7, 4 },
                    { 46, new DateTime(2023, 6, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9141), new DateTime(2022, 12, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9142), 5, 2 },
                    { 47, new DateTime(2022, 1, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9145), new DateTime(2024, 8, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9146), 4, 4 },
                    { 48, new DateTime(2023, 6, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9148), new DateTime(2024, 11, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9149), 4, 4 },
                    { 49, new DateTime(2022, 4, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9151), new DateTime(2024, 8, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9152), 4, 4 },
                    { 50, new DateTime(2022, 10, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9154), new DateTime(2024, 10, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9155), 5, 4 },
                    { 51, new DateTime(2023, 5, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9157), new DateTime(2025, 2, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9158), 4, 3 },
                    { 52, new DateTime(2022, 9, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9160), new DateTime(2025, 1, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9161), 8, 4 },
                    { 53, new DateTime(2022, 8, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 5, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9164), 9, 3 },
                    { 54, new DateTime(2022, 9, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9166), new DateTime(2022, 6, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9167), 8, 2 },
                    { 55, new DateTime(2022, 7, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9169), new DateTime(2024, 6, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9170), 1, 4 },
                    { 56, new DateTime(2023, 1, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 4, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9174), 5, 3 },
                    { 57, new DateTime(2023, 4, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 9, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9177), 1, 3 },
                    { 58, new DateTime(2022, 7, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9179), new DateTime(2025, 4, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9180), 7, 4 },
                    { 59, new DateTime(2022, 8, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9182), new DateTime(2025, 1, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9183), 1, 4 },
                    { 60, new DateTime(2022, 8, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 3, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9186), 5, 4 },
                    { 61, new DateTime(2022, 9, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 11, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9189), 5, 4 },
                    { 62, new DateTime(2022, 6, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9191), new DateTime(2024, 12, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9192), 8, 3 },
                    { 63, new DateTime(2023, 6, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9194), new DateTime(2024, 2, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9195), 7, 4 },
                    { 64, new DateTime(2022, 5, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9197), new DateTime(2024, 8, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9198), 9, 3 },
                    { 65, new DateTime(2022, 1, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9200), new DateTime(2024, 10, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9201), 5, 4 },
                    { 66, new DateTime(2021, 11, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 4, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9205), 5, 4 },
                    { 67, new DateTime(2022, 8, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9207), new DateTime(2025, 5, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9207), 9, 4 },
                    { 68, new DateTime(2023, 7, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9210), new DateTime(2025, 3, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9210), 7, 4 },
                    { 69, new DateTime(2022, 1, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9212), new DateTime(2024, 5, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9213), 5, 4 },
                    { 70, new DateTime(2022, 7, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9215), new DateTime(2025, 6, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9216), 7, 4 },
                    { 71, new DateTime(2022, 10, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9218), new DateTime(2025, 3, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9219), 2, 4 },
                    { 72, new DateTime(2022, 10, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 1, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9222), 8, 4 },
                    { 73, new DateTime(2022, 9, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9223), new DateTime(2024, 11, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9224), 2, 4 },
                    { 74, new DateTime(2022, 10, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9226), new DateTime(2024, 1, 11, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9227), 9, 4 },
                    { 75, new DateTime(2023, 5, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9229), new DateTime(2024, 11, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9230), 6, 4 },
                    { 76, new DateTime(2023, 3, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9232), new DateTime(2025, 7, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9233), 7, 4 },
                    { 77, new DateTime(2023, 3, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9235), new DateTime(2024, 5, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9236), 1, 4 },
                    { 78, new DateTime(2022, 6, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9237), new DateTime(2025, 3, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9238), 8, 4 },
                    { 79, new DateTime(2022, 8, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9240), new DateTime(2025, 3, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9241), 5, 4 },
                    { 80, new DateTime(2022, 2, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9243), new DateTime(2024, 6, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9244), 1, 4 },
                    { 81, new DateTime(2022, 7, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9246), new DateTime(2024, 12, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9247), 5, 4 },
                    { 82, new DateTime(2023, 6, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9249), new DateTime(2024, 11, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9250), 2, 4 },
                    { 83, new DateTime(2022, 9, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9252), new DateTime(2024, 8, 31, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9253), 1, 4 },
                    { 84, new DateTime(2023, 3, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9255), new DateTime(2025, 1, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9256), 1, 4 },
                    { 85, new DateTime(2023, 1, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9258), new DateTime(2024, 6, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9259), 3, 4 },
                    { 86, new DateTime(2022, 6, 11, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9261), new DateTime(2025, 3, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9262), 3, 4 },
                    { 87, new DateTime(2022, 6, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9264), new DateTime(2024, 6, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9264), 9, 4 },
                    { 88, new DateTime(2021, 12, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9266), new DateTime(2025, 3, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9267), 6, 4 },
                    { 89, new DateTime(2023, 6, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9269), new DateTime(2025, 1, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9270), 3, 4 },
                    { 90, new DateTime(2022, 9, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9272), new DateTime(2022, 7, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9273), 5, 2 },
                    { 91, new DateTime(2022, 7, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9275), new DateTime(2024, 8, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9276), 6, 4 },
                    { 92, new DateTime(2022, 11, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9278), new DateTime(2024, 7, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9279), 6, 3 },
                    { 93, new DateTime(2023, 4, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9281), new DateTime(2024, 12, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9282), 9, 4 },
                    { 94, new DateTime(2021, 12, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9284), new DateTime(2024, 6, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9285), 6, 4 },
                    { 95, new DateTime(2022, 8, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9287), new DateTime(2024, 8, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9288), 8, 4 },
                    { 96, new DateTime(2022, 1, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9290), new DateTime(2024, 3, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9291), 3, 4 },
                    { 97, new DateTime(2021, 11, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 12, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9313), 2, 4 },
                    { 98, new DateTime(2021, 12, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9315), new DateTime(2025, 5, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9316), 8, 4 },
                    { 99, new DateTime(2023, 3, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9319), new DateTime(2024, 11, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9319), 9, 4 },
                    { 100, new DateTime(2022, 3, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9322), new DateTime(2024, 3, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9323), 2, 4 },
                    { 101, new DateTime(2022, 10, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9325), new DateTime(2025, 8, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9326), 5, 4 },
                    { 102, new DateTime(2022, 11, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 10, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9329), 5, 4 },
                    { 103, new DateTime(2022, 2, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 9, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9333), 9, 1 },
                    { 104, new DateTime(2023, 1, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9335), new DateTime(2024, 10, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9336), 1, 1 },
                    { 105, new DateTime(2022, 12, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9338), new DateTime(2025, 7, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9339), 1, 1 },
                    { 106, new DateTime(2022, 10, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9341), new DateTime(2022, 10, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9342), 5, 2 },
                    { 107, new DateTime(2023, 4, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9344), new DateTime(2024, 1, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9345), 3, 1 },
                    { 108, new DateTime(2022, 8, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9347), new DateTime(2024, 12, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9348), 2, 1 },
                    { 109, new DateTime(2022, 9, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9350), new DateTime(2024, 12, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9351), 7, 1 },
                    { 110, new DateTime(2022, 12, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9353), new DateTime(2024, 5, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9354), 9, 1 },
                    { 111, new DateTime(2022, 3, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9356), new DateTime(2024, 6, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9356), 5, 1 },
                    { 112, new DateTime(2023, 7, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9358), new DateTime(2024, 4, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9359), 2, 1 },
                    { 113, new DateTime(2023, 5, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9361), new DateTime(2024, 4, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9362), 2, 1 },
                    { 114, new DateTime(2022, 8, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9364), new DateTime(2024, 10, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9365), 1, 1 },
                    { 115, new DateTime(2022, 6, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9367), new DateTime(2024, 10, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9368), 3, 1 },
                    { 116, new DateTime(2022, 8, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9370), new DateTime(2025, 2, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9371), 8, 1 },
                    { 117, new DateTime(2023, 2, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9373), new DateTime(2024, 10, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9374), 1, 1 },
                    { 118, new DateTime(2023, 2, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9376), new DateTime(2024, 8, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9377), 2, 1 },
                    { 119, new DateTime(2023, 5, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9379), new DateTime(2025, 7, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9380), 1, 1 },
                    { 120, new DateTime(2022, 10, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9382), new DateTime(2025, 1, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9383), 8, 3 },
                    { 121, new DateTime(2023, 4, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9385), new DateTime(2025, 3, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9385), 3, 1 },
                    { 122, new DateTime(2022, 11, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9387), new DateTime(2024, 4, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9388), 3, 1 },
                    { 123, new DateTime(2022, 8, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9390), new DateTime(2022, 2, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9391), 8, 2 },
                    { 124, new DateTime(2022, 11, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9393), new DateTime(2024, 12, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9394), 2, 1 },
                    { 125, new DateTime(2022, 4, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9396), new DateTime(2024, 6, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9397), 3, 1 },
                    { 126, new DateTime(2022, 7, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9399), new DateTime(2025, 5, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9400), 9, 1 },
                    { 127, new DateTime(2022, 1, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9402), new DateTime(2024, 11, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9403), 5, 1 },
                    { 128, new DateTime(2022, 11, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9405), new DateTime(2025, 4, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9406), 5, 1 },
                    { 129, new DateTime(2022, 6, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9408), new DateTime(2024, 7, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9409), 3, 1 },
                    { 130, new DateTime(2023, 3, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9412), new DateTime(2025, 7, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9413), 2, 1 },
                    { 131, new DateTime(2023, 8, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9415), new DateTime(2024, 8, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9416), 4, 1 },
                    { 132, new DateTime(2023, 1, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9418), new DateTime(2024, 10, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9419), 4, 1 },
                    { 133, new DateTime(2022, 12, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9421), new DateTime(2024, 7, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9422), 7, 3 },
                    { 134, new DateTime(2022, 11, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9424), new DateTime(2025, 2, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9424), 9, 1 },
                    { 135, new DateTime(2023, 1, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9427), new DateTime(2023, 3, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9428), 8, 2 },
                    { 136, new DateTime(2022, 7, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9430), new DateTime(2024, 8, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9431), 7, 1 },
                    { 137, new DateTime(2022, 10, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9433), new DateTime(2024, 10, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9434), 2, 1 },
                    { 138, new DateTime(2023, 3, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9436), new DateTime(2025, 5, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9437), 2, 1 },
                    { 139, new DateTime(2023, 1, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9438), new DateTime(2024, 1, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9439), 4, 1 },
                    { 140, new DateTime(2022, 5, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9441), new DateTime(2024, 4, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9442), 8, 1 },
                    { 141, new DateTime(2023, 1, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 5, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9445), 7, 1 },
                    { 142, new DateTime(2022, 6, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9447), new DateTime(2024, 6, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9448), 4, 1 },
                    { 143, new DateTime(2022, 7, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 7, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9451), 2, 1 },
                    { 144, new DateTime(2022, 8, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9453), new DateTime(2025, 2, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9454), 1, 1 },
                    { 145, new DateTime(2021, 11, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9456), new DateTime(2024, 10, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9457), 6, 1 },
                    { 146, new DateTime(2022, 7, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9459), new DateTime(2024, 6, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9460), 5, 1 },
                    { 147, new DateTime(2022, 3, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9462), new DateTime(2025, 2, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9463), 3, 1 },
                    { 148, new DateTime(2022, 6, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 9, 11, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9466), 3, 1 },
                    { 149, new DateTime(2022, 4, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9467), new DateTime(2025, 3, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9468), 5, 1 },
                    { 150, new DateTime(2022, 11, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9470), new DateTime(2024, 8, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9471), 7, 1 },
                    { 151, new DateTime(2022, 5, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 3, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9474), 9, 1 },
                    { 152, new DateTime(2022, 10, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 10, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9477), 5, 1 },
                    { 153, new DateTime(2022, 10, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9479), new DateTime(2024, 12, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9480), 8, 1 },
                    { 154, new DateTime(2022, 3, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9482), new DateTime(2024, 10, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9482), 4, 1 },
                    { 155, new DateTime(2023, 1, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 3, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9485), 9, 1 },
                    { 156, new DateTime(2023, 4, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9487), new DateTime(2024, 7, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9488), 8, 1 },
                    { 157, new DateTime(2022, 1, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9490), new DateTime(2024, 9, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9491), 2, 1 },
                    { 158, new DateTime(2023, 2, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9493), new DateTime(2024, 11, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9494), 8, 1 },
                    { 159, new DateTime(2023, 1, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9496), new DateTime(2024, 10, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9497), 7, 1 },
                    { 160, new DateTime(2023, 8, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9499), new DateTime(2022, 7, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9499), 1, 2 },
                    { 161, new DateTime(2022, 10, 31, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9520), new DateTime(2025, 2, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9521), 4, 1 },
                    { 162, new DateTime(2022, 6, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9523), new DateTime(2025, 1, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9524), 2, 1 },
                    { 163, new DateTime(2022, 10, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9526), new DateTime(2024, 10, 11, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9527), 9, 1 },
                    { 164, new DateTime(2023, 4, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9529), new DateTime(2022, 11, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9530), 3, 2 },
                    { 165, new DateTime(2022, 1, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9532), new DateTime(2024, 4, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9533), 7, 1 },
                    { 166, new DateTime(2022, 9, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9535), new DateTime(2024, 12, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9536), 9, 1 },
                    { 167, new DateTime(2022, 12, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9538), new DateTime(2024, 7, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9539), 7, 1 },
                    { 168, new DateTime(2022, 5, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 12, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9542), 4, 1 },
                    { 169, new DateTime(2022, 8, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9544), new DateTime(2025, 2, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9545), 4, 1 },
                    { 170, new DateTime(2023, 2, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9547), new DateTime(2024, 10, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9548), 5, 3 },
                    { 171, new DateTime(2023, 4, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9550), new DateTime(2024, 6, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9551), 9, 1 },
                    { 172, new DateTime(2023, 4, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9553), new DateTime(2024, 11, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9554), 9, 1 },
                    { 173, new DateTime(2023, 2, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 10, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9557), 5, 1 },
                    { 174, new DateTime(2023, 3, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 6, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9560), 8, 1 },
                    { 175, new DateTime(2023, 6, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9562), new DateTime(2024, 3, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9563), 5, 1 },
                    { 176, new DateTime(2022, 3, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9565), new DateTime(2024, 7, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9566), 2, 1 },
                    { 177, new DateTime(2022, 5, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9568), new DateTime(2024, 11, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9569), 9, 1 },
                    { 178, new DateTime(2022, 11, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9571), new DateTime(2022, 6, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9572), 3, 2 },
                    { 179, new DateTime(2022, 11, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9574), new DateTime(2024, 7, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9575), 8, 1 },
                    { 180, new DateTime(2022, 6, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 5, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9578), 4, 1 },
                    { 181, new DateTime(2023, 3, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 12, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9580), 4, 1 },
                    { 182, new DateTime(2023, 5, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9582), new DateTime(2025, 3, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9583), 4, 1 },
                    { 183, new DateTime(2023, 1, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9585), new DateTime(2024, 6, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9586), 3, 3 },
                    { 184, new DateTime(2022, 2, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9588), new DateTime(2024, 2, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9589), 9, 1 },
                    { 185, new DateTime(2023, 6, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9590), new DateTime(2024, 6, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9591), 5, 1 },
                    { 186, new DateTime(2021, 11, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9593), new DateTime(2024, 5, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9594), 8, 1 },
                    { 187, new DateTime(2022, 8, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 3, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9597), 8, 1 },
                    { 188, new DateTime(2022, 6, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9599), new DateTime(2024, 6, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9600), 1, 1 },
                    { 189, new DateTime(2023, 2, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9602), new DateTime(2025, 6, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9602), 2, 3 },
                    { 190, new DateTime(2022, 12, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9604), new DateTime(2025, 4, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9605), 3, 1 },
                    { 191, new DateTime(2023, 5, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9607), new DateTime(2024, 6, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9608), 5, 1 },
                    { 192, new DateTime(2022, 7, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9610), new DateTime(2024, 4, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9611), 7, 1 },
                    { 193, new DateTime(2023, 7, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9613), new DateTime(2025, 1, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9613), 2, 1 },
                    { 194, new DateTime(2023, 2, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9615), new DateTime(2024, 10, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9617), 8, 3 },
                    { 195, new DateTime(2023, 7, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9619), new DateTime(2024, 1, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9619), 1, 1 },
                    { 196, new DateTime(2023, 2, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9622), new DateTime(2024, 9, 11, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9623), 5, 1 },
                    { 197, new DateTime(2022, 4, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 8, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9626), 8, 1 },
                    { 198, new DateTime(2023, 3, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9628), new DateTime(2024, 7, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9629), 3, 1 },
                    { 199, new DateTime(2023, 1, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 7, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9631), 4, 1 },
                    { 200, new DateTime(2022, 12, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9633), new DateTime(2024, 5, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9634), 5, 1 },
                    { 201, new DateTime(2022, 1, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9636), new DateTime(2024, 7, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9636), 3, 1 },
                    { 202, new DateTime(2022, 7, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9638), new DateTime(2024, 6, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9640), 6, 1 },
                    { 203, new DateTime(2022, 8, 11, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9641), new DateTime(2024, 8, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9642), 3, 1 },
                    { 204, new DateTime(2023, 4, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9644), new DateTime(2023, 11, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9645), 8, 1 },
                    { 205, new DateTime(2023, 2, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9647), new DateTime(2023, 12, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9648), 2, 3 },
                    { 206, new DateTime(2023, 4, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9651), new DateTime(2025, 4, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9652), 7, 1 },
                    { 207, new DateTime(2022, 9, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9653), new DateTime(2024, 8, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9655), 5, 1 },
                    { 208, new DateTime(2022, 12, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9656), new DateTime(2024, 11, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9657), 4, 1 },
                    { 209, new DateTime(2022, 5, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 9, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9660), 4, 1 },
                    { 210, new DateTime(2022, 7, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9662), new DateTime(2024, 10, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9663), 7, 1 },
                    { 211, new DateTime(2022, 9, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9665), new DateTime(2025, 3, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9666), 4, 3 },
                    { 212, new DateTime(2022, 4, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 11, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9669), 9, 3 },
                    { 213, new DateTime(2022, 8, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 7, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9672), 3, 1 },
                    { 214, new DateTime(2022, 9, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9674), new DateTime(2024, 11, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9675), 2, 1 },
                    { 215, new DateTime(2022, 7, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9677), new DateTime(2025, 5, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9678), 7, 1 },
                    { 216, new DateTime(2022, 12, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9680), new DateTime(2024, 4, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9681), 3, 1 },
                    { 217, new DateTime(2023, 1, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9683), new DateTime(2024, 4, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9684), 2, 1 },
                    { 218, new DateTime(2022, 6, 11, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9686), new DateTime(2022, 4, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9687), 2, 2 },
                    { 219, new DateTime(2022, 11, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9689), new DateTime(2024, 7, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9690), 8, 1 },
                    { 220, new DateTime(2023, 2, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9692), new DateTime(2024, 12, 11, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9693), 2, 1 },
                    { 221, new DateTime(2022, 12, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 3, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9696), 6, 1 },
                    { 222, new DateTime(2022, 12, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9698), new DateTime(2025, 1, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9699), 9, 1 },
                    { 223, new DateTime(2022, 4, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9701), new DateTime(2022, 2, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9702), 3, 2 },
                    { 224, new DateTime(2022, 3, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9704), new DateTime(2025, 5, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9705), 9, 1 },
                    { 225, new DateTime(2021, 12, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 11, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9708), 1, 1 },
                    { 226, new DateTime(2022, 9, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9710), new DateTime(2023, 11, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9711), 6, 1 },
                    { 227, new DateTime(2022, 7, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9713), new DateTime(2024, 7, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9714), 7, 3 },
                    { 228, new DateTime(2022, 12, 19, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 9, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9717), 9, 1 },
                    { 229, new DateTime(2022, 9, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9719), new DateTime(2022, 2, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9720), 6, 2 },
                    { 230, new DateTime(2022, 12, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 11, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9723), 9, 1 },
                    { 231, new DateTime(2022, 1, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9725), new DateTime(2024, 1, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9725), 4, 1 },
                    { 232, new DateTime(2022, 7, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9727), new DateTime(2023, 3, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9728), 5, 2 },
                    { 233, new DateTime(2022, 11, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9731), new DateTime(2025, 1, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9731), 6, 3 },
                    { 234, new DateTime(2023, 4, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9734), new DateTime(2024, 11, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9735), 1, 1 },
                    { 235, new DateTime(2023, 2, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9737), new DateTime(2024, 1, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9738), 1, 1 },
                    { 236, new DateTime(2022, 7, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9740), new DateTime(2025, 6, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9741), 6, 3 },
                    { 237, new DateTime(2023, 1, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9743), new DateTime(2024, 12, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9744), 4, 1 },
                    { 238, new DateTime(2023, 6, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9746), new DateTime(2024, 3, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9746), 5, 1 },
                    { 239, new DateTime(2022, 6, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9749), new DateTime(2024, 6, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9750), 2, 1 },
                    { 240, new DateTime(2022, 11, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9751), new DateTime(2024, 8, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9752), 1, 3 },
                    { 241, new DateTime(2023, 1, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9754), new DateTime(2024, 12, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9755), 4, 3 },
                    { 242, new DateTime(2022, 8, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9757), new DateTime(2024, 5, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9758), 3, 1 },
                    { 243, new DateTime(2022, 10, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9760), new DateTime(2024, 8, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9761), 5, 3 },
                    { 244, new DateTime(2022, 9, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9763), new DateTime(2024, 12, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9764), 6, 1 },
                    { 245, new DateTime(2023, 5, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9766), new DateTime(2024, 3, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9766), 2, 1 },
                    { 246, new DateTime(2023, 3, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9855), new DateTime(2023, 4, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9856), 7, 2 },
                    { 247, new DateTime(2022, 10, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9858), new DateTime(2024, 12, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9859), 7, 1 },
                    { 248, new DateTime(2022, 10, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9861), new DateTime(2025, 3, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9862), 5, 1 },
                    { 249, new DateTime(2023, 2, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9864), new DateTime(2024, 10, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9865), 9, 1 },
                    { 250, new DateTime(2023, 2, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9867), new DateTime(2025, 3, 3, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9868), 2, 1 },
                    { 251, new DateTime(2022, 4, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9870), new DateTime(2025, 6, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9871), 4, 1 },
                    { 252, new DateTime(2023, 1, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9873), new DateTime(2024, 10, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9874), 6, 1 },
                    { 253, new DateTime(2023, 6, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9875), new DateTime(2023, 11, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9876), 5, 1 },
                    { 254, new DateTime(2022, 4, 2, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9878), new DateTime(2024, 10, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9879), 7, 1 },
                    { 255, new DateTime(2022, 12, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9881), new DateTime(2024, 6, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9882), 2, 1 },
                    { 256, new DateTime(2022, 9, 20, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9884), new DateTime(2024, 12, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9885), 3, 1 },
                    { 257, new DateTime(2023, 1, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9887), new DateTime(2024, 8, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9888), 4, 1 },
                    { 258, new DateTime(2022, 11, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9892), new DateTime(2025, 2, 11, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9893), 8, 3 },
                    { 259, new DateTime(2022, 8, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9895), new DateTime(2024, 12, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9896), 4, 1 },
                    { 260, new DateTime(2022, 11, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9898), new DateTime(2024, 12, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9899), 4, 1 },
                    { 261, new DateTime(2022, 8, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9901), new DateTime(2025, 6, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9902), 9, 1 },
                    { 262, new DateTime(2022, 6, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9904), new DateTime(2023, 12, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9904), 3, 1 },
                    { 263, new DateTime(2023, 5, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9906), new DateTime(2024, 5, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9907), 5, 1 },
                    { 264, new DateTime(2023, 4, 23, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 11, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9910), 9, 1 },
                    { 265, new DateTime(2023, 1, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9912), new DateTime(2025, 2, 27, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9913), 4, 1 },
                    { 266, new DateTime(2023, 3, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9915), new DateTime(2024, 3, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9916), 3, 1 },
                    { 267, new DateTime(2022, 7, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 11, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9919), 2, 1 },
                    { 268, new DateTime(2022, 7, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9922), new DateTime(2024, 9, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9923), 2, 1 },
                    { 269, new DateTime(2022, 2, 9, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9925), new DateTime(2024, 12, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9926), 4, 1 },
                    { 270, new DateTime(2021, 11, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9928), new DateTime(2025, 3, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9928), 4, 1 },
                    { 271, new DateTime(2022, 11, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 9, 5, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9931), 9, 1 },
                    { 272, new DateTime(2022, 10, 17, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 8, 7, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9934), 5, 1 },
                    { 273, new DateTime(2022, 3, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9936), new DateTime(2025, 5, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9937), 4, 1 },
                    { 274, new DateTime(2022, 12, 1, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9940), new DateTime(2025, 6, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9941), 1, 1 },
                    { 275, new DateTime(2021, 12, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9943), new DateTime(2024, 3, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9944), 7, 1 },
                    { 276, new DateTime(2022, 3, 6, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9946), new DateTime(2024, 9, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9947), 4, 1 },
                    { 277, new DateTime(2023, 5, 12, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 3, 4, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9950), 4, 3 },
                    { 278, new DateTime(2023, 4, 21, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 5, 29, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9953), 7, 1 },
                    { 279, new DateTime(2021, 12, 13, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9955), new DateTime(2024, 9, 25, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9956), 9, 3 },
                    { 280, new DateTime(2022, 11, 28, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9958), new DateTime(2024, 12, 11, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9959), 7, 1 },
                    { 281, new DateTime(2022, 9, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9961), new DateTime(2024, 3, 8, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9962), 9, 1 },
                    { 282, new DateTime(2022, 2, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9964), new DateTime(2024, 11, 30, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9965), 5, 1 },
                    { 283, new DateTime(2023, 2, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 10, 10, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9968), 3, 1 },
                    { 284, new DateTime(2022, 4, 15, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9970), new DateTime(2024, 2, 18, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9971), 3, 1 },
                    { 285, new DateTime(2022, 9, 14, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9973), new DateTime(2024, 6, 16, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9974), 5, 1 },
                    { 286, new DateTime(2023, 8, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 8, 26, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9977), 6, 1 },
                    { 287, new DateTime(2022, 10, 22, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 3, 24, 11, 38, 9, 260, DateTimeKind.Local).AddTicks(9980), 9, 1 },
                    { 288, new DateTime(2022, 8, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 11, 11, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(11), 3, 3 },
                    { 289, new DateTime(2022, 10, 14, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(13), new DateTime(2022, 2, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(14), 2, 2 },
                    { 290, new DateTime(2022, 10, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(16), new DateTime(2023, 8, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(17), 6, 2 },
                    { 291, new DateTime(2022, 5, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 8, 27, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(20), 4, 1 },
                    { 292, new DateTime(2023, 3, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(22), new DateTime(2025, 2, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(23), 6, 1 },
                    { 293, new DateTime(2021, 12, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(25), new DateTime(2025, 4, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(26), 4, 1 },
                    { 294, new DateTime(2023, 8, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(28), new DateTime(2022, 7, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(29), 3, 2 },
                    { 295, new DateTime(2022, 6, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(31), new DateTime(2024, 11, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(32), 1, 1 },
                    { 296, new DateTime(2022, 8, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 10, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(35), 9, 1 },
                    { 297, new DateTime(2022, 6, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(37), new DateTime(2024, 2, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(38), 2, 1 },
                    { 298, new DateTime(2023, 2, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(41), new DateTime(2024, 9, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(42), 3, 1 },
                    { 299, new DateTime(2022, 11, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(44), new DateTime(2024, 11, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(45), 4, 1 },
                    { 300, new DateTime(2022, 5, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(47), new DateTime(2024, 5, 27, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(48), 7, 1 },
                    { 301, new DateTime(2022, 8, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(50), new DateTime(2024, 12, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(51), 5, 1 },
                    { 302, new DateTime(2022, 10, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(53), new DateTime(2024, 3, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(54), 6, 1 },
                    { 303, new DateTime(2022, 3, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(56), new DateTime(2024, 6, 27, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(57), 4, 1 },
                    { 304, new DateTime(2022, 5, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 7, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(60), 1, 1 },
                    { 305, new DateTime(2023, 1, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(62), new DateTime(2024, 4, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(63), 2, 3 },
                    { 306, new DateTime(2022, 7, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 8, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(66), 1, 1 },
                    { 307, new DateTime(2022, 10, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 9, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(69), 7, 1 },
                    { 308, new DateTime(2022, 12, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 12, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(72), 5, 1 },
                    { 309, new DateTime(2022, 12, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(74), new DateTime(2025, 5, 15, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(75), 1, 1 },
                    { 310, new DateTime(2022, 2, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(77), new DateTime(2024, 8, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(78), 2, 1 },
                    { 311, new DateTime(2022, 5, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(80), new DateTime(2024, 8, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(81), 7, 1 },
                    { 312, new DateTime(2022, 3, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(83), new DateTime(2024, 3, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(84), 6, 3 },
                    { 313, new DateTime(2023, 1, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(86), new DateTime(2024, 8, 27, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(87), 2, 3 },
                    { 314, new DateTime(2023, 1, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(89), new DateTime(2024, 11, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(90), 1, 1 },
                    { 315, new DateTime(2022, 2, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(92), new DateTime(2024, 2, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(93), 6, 1 },
                    { 316, new DateTime(2022, 11, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(95), new DateTime(2025, 1, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(96), 9, 1 },
                    { 317, new DateTime(2022, 8, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(98), new DateTime(2024, 12, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(98), 7, 1 },
                    { 318, new DateTime(2021, 12, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 5, 31, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(101), 5, 1 },
                    { 319, new DateTime(2022, 4, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(103), new DateTime(2024, 3, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(104), 7, 1 },
                    { 320, new DateTime(2023, 1, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(106), new DateTime(2025, 6, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(107), 1, 3 },
                    { 321, new DateTime(2023, 4, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(109), new DateTime(2024, 8, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(110), 4, 1 },
                    { 322, new DateTime(2023, 4, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(112), new DateTime(2025, 1, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(113), 9, 1 },
                    { 323, new DateTime(2022, 12, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(115), new DateTime(2024, 5, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(116), 8, 3 },
                    { 324, new DateTime(2022, 9, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(118), new DateTime(2024, 10, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(119), 7, 1 },
                    { 325, new DateTime(2023, 6, 23, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(121), new DateTime(2024, 7, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(122), 6, 1 },
                    { 326, new DateTime(2022, 10, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(124), new DateTime(2024, 10, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(125), 2, 1 },
                    { 327, new DateTime(2021, 12, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 3, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(128), 8, 1 },
                    { 328, new DateTime(2023, 5, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 5, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(131), 5, 1 },
                    { 329, new DateTime(2023, 4, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(133), new DateTime(2025, 5, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(134), 2, 1 },
                    { 330, new DateTime(2022, 6, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(136), new DateTime(2024, 9, 11, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(137), 7, 1 },
                    { 331, new DateTime(2023, 7, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(138), new DateTime(2024, 9, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(140), 9, 1 },
                    { 332, new DateTime(2023, 3, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(141), new DateTime(2024, 10, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(142), 5, 1 },
                    { 333, new DateTime(2022, 6, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 12, 31, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(145), 3, 1 },
                    { 334, new DateTime(2022, 8, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(147), new DateTime(2025, 1, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(148), 7, 3 },
                    { 335, new DateTime(2023, 8, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(150), new DateTime(2025, 7, 24, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(151), 6, 1 },
                    { 336, new DateTime(2022, 3, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(153), new DateTime(2025, 7, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(154), 5, 1 },
                    { 337, new DateTime(2022, 9, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(156), new DateTime(2025, 1, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(157), 1, 1 },
                    { 338, new DateTime(2022, 10, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(159), new DateTime(2025, 1, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(160), 2, 1 },
                    { 339, new DateTime(2022, 1, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(162), new DateTime(2023, 3, 27, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(163), 5, 2 },
                    { 340, new DateTime(2022, 7, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(165), new DateTime(2024, 2, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(166), 3, 1 },
                    { 341, new DateTime(2022, 7, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(167), new DateTime(2025, 8, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(168), 6, 1 },
                    { 342, new DateTime(2023, 1, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(170), new DateTime(2022, 8, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(171), 4, 2 },
                    { 343, new DateTime(2022, 11, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(174), new DateTime(2022, 9, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(175), 5, 2 },
                    { 344, new DateTime(2021, 12, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(177), new DateTime(2024, 3, 24, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(178), 2, 1 },
                    { 345, new DateTime(2022, 9, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 12, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(181), 5, 3 },
                    { 346, new DateTime(2022, 3, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(183), new DateTime(2024, 9, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(183), 7, 1 },
                    { 347, new DateTime(2022, 9, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(186), new DateTime(2022, 9, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(187), 7, 2 },
                    { 348, new DateTime(2023, 6, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(189), new DateTime(2024, 8, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(190), 7, 1 },
                    { 349, new DateTime(2022, 3, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(192), new DateTime(2024, 9, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(193), 8, 1 },
                    { 350, new DateTime(2022, 5, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(195), new DateTime(2023, 7, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(196), 1, 2 },
                    { 351, new DateTime(2022, 6, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(198), new DateTime(2022, 8, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(199), 7, 2 },
                    { 352, new DateTime(2023, 1, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(201), new DateTime(2024, 11, 14, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(202), 1, 1 },
                    { 353, new DateTime(2023, 4, 27, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(204), new DateTime(2025, 2, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(205), 8, 1 },
                    { 354, new DateTime(2022, 8, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(207), new DateTime(2024, 4, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(208), 5, 1 },
                    { 355, new DateTime(2023, 3, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(209), new DateTime(2024, 2, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(210), 8, 1 },
                    { 356, new DateTime(2023, 3, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 11, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(213), 8, 1 },
                    { 357, new DateTime(2023, 6, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(215), new DateTime(2025, 2, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(216), 3, 1 },
                    { 358, new DateTime(2023, 5, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(218), new DateTime(2025, 5, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(219), 4, 1 },
                    { 359, new DateTime(2021, 12, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(221), new DateTime(2024, 7, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(222), 7, 3 },
                    { 360, new DateTime(2021, 11, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(224), new DateTime(2025, 3, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(225), 9, 1 },
                    { 361, new DateTime(2023, 8, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(227), new DateTime(2025, 7, 14, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(228), 3, 1 },
                    { 362, new DateTime(2022, 7, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 2, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(231), 2, 1 },
                    { 363, new DateTime(2023, 3, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(233), new DateTime(2025, 2, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(234), 1, 1 },
                    { 364, new DateTime(2022, 12, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(236), new DateTime(2025, 4, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(237), 2, 1 },
                    { 365, new DateTime(2022, 8, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(239), new DateTime(2022, 11, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(240), 6, 2 },
                    { 366, new DateTime(2022, 5, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(242), new DateTime(2024, 6, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(243), 5, 1 },
                    { 367, new DateTime(2023, 8, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 6, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(246), 5, 1 },
                    { 368, new DateTime(2022, 7, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(248), new DateTime(2024, 6, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(249), 6, 3 },
                    { 369, new DateTime(2022, 4, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(251), new DateTime(2024, 3, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(252), 1, 1 },
                    { 370, new DateTime(2022, 10, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(254), new DateTime(2024, 10, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(255), 8, 1 },
                    { 371, new DateTime(2022, 8, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(257), new DateTime(2024, 8, 14, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(258), 9, 1 },
                    { 372, new DateTime(2022, 9, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(260), new DateTime(2022, 5, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(261), 5, 2 },
                    { 373, new DateTime(2022, 10, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(286), new DateTime(2024, 4, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(287), 6, 1 },
                    { 374, new DateTime(2023, 3, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 11, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(289), 5, 3 },
                    { 375, new DateTime(2023, 1, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(291), new DateTime(2024, 3, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(292), 6, 3 },
                    { 376, new DateTime(2022, 9, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(294), new DateTime(2024, 9, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(295), 7, 1 },
                    { 377, new DateTime(2023, 3, 15, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 12, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(298), 8, 1 },
                    { 378, new DateTime(2022, 3, 24, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(300), new DateTime(2025, 4, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(301), 8, 1 },
                    { 379, new DateTime(2022, 11, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(303), new DateTime(2025, 8, 11, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(304), 2, 1 },
                    { 380, new DateTime(2022, 9, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 7, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(307), 9, 3 },
                    { 381, new DateTime(2022, 6, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(309), new DateTime(2024, 5, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(309), 1, 1 },
                    { 382, new DateTime(2022, 11, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(311), new DateTime(2022, 9, 24, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(313), 6, 2 },
                    { 383, new DateTime(2022, 11, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(315), new DateTime(2024, 12, 11, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(316), 2, 1 },
                    { 384, new DateTime(2023, 2, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(317), new DateTime(2024, 9, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(318), 4, 1 },
                    { 385, new DateTime(2022, 10, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 5, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(321), 7, 1 },
                    { 386, new DateTime(2022, 8, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(323), new DateTime(2024, 5, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(324), 8, 1 },
                    { 387, new DateTime(2023, 2, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(326), new DateTime(2024, 5, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(327), 7, 1 },
                    { 388, new DateTime(2022, 6, 15, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(329), new DateTime(2024, 10, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(330), 1, 1 },
                    { 389, new DateTime(2022, 10, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(331), new DateTime(2024, 7, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(332), 9, 1 },
                    { 390, new DateTime(2022, 8, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(334), new DateTime(2025, 1, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(335), 8, 1 },
                    { 391, new DateTime(2023, 3, 14, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(337), new DateTime(2024, 9, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(338), 7, 1 },
                    { 392, new DateTime(2022, 6, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(340), new DateTime(2023, 12, 27, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(341), 5, 1 },
                    { 393, new DateTime(2023, 4, 14, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(343), new DateTime(2025, 5, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(343), 4, 1 },
                    { 394, new DateTime(2022, 9, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(346), new DateTime(2024, 5, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(347), 7, 1 },
                    { 395, new DateTime(2022, 6, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(349), new DateTime(2024, 7, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(349), 5, 1 },
                    { 396, new DateTime(2022, 5, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 6, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(352), 6, 1 },
                    { 397, new DateTime(2022, 12, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(355), new DateTime(2024, 3, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(356), 4, 1 },
                    { 398, new DateTime(2022, 7, 23, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(357), new DateTime(2024, 3, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(358), 6, 1 },
                    { 399, new DateTime(2022, 12, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(360), new DateTime(2024, 8, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(361), 3, 3 },
                    { 400, new DateTime(2023, 3, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(363), new DateTime(2024, 5, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(363), 5, 1 },
                    { 401, new DateTime(2023, 1, 11, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(365), new DateTime(2025, 4, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(366), 5, 1 },
                    { 402, new DateTime(2023, 6, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(368), new DateTime(2024, 3, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(369), 4, 1 },
                    { 403, new DateTime(2022, 10, 15, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(371), new DateTime(2024, 8, 31, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(372), 6, 1 },
                    { 404, new DateTime(2023, 1, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(374), new DateTime(2024, 10, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(375), 8, 1 },
                    { 405, new DateTime(2022, 9, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(377), new DateTime(2022, 6, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(378), 7, 2 },
                    { 406, new DateTime(2022, 8, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(380), new DateTime(2024, 7, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(381), 7, 1 },
                    { 407, new DateTime(2022, 7, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(383), new DateTime(2024, 11, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(384), 3, 3 },
                    { 408, new DateTime(2022, 10, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(386), new DateTime(2024, 10, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(387), 5, 1 },
                    { 409, new DateTime(2023, 2, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(388), new DateTime(2024, 12, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(389), 7, 1 },
                    { 410, new DateTime(2022, 7, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(391), new DateTime(2024, 5, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(392), 9, 1 },
                    { 411, new DateTime(2023, 3, 23, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(394), new DateTime(2025, 3, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(395), 8, 1 },
                    { 412, new DateTime(2021, 11, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(397), new DateTime(2025, 2, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(398), 4, 1 },
                    { 413, new DateTime(2022, 7, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(400), new DateTime(2024, 8, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(401), 9, 1 },
                    { 414, new DateTime(2022, 5, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(403), new DateTime(2023, 11, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(404), 8, 1 },
                    { 415, new DateTime(2023, 6, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(406), new DateTime(2024, 11, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(407), 9, 1 },
                    { 416, new DateTime(2022, 10, 14, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(409), new DateTime(2024, 1, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(410), 4, 1 },
                    { 417, new DateTime(2022, 8, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(412), new DateTime(2022, 7, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(413), 8, 2 },
                    { 418, new DateTime(2022, 10, 14, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(416), new DateTime(2024, 8, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(416), 8, 1 },
                    { 419, new DateTime(2023, 2, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(418), new DateTime(2022, 9, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(420), 1, 2 },
                    { 420, new DateTime(2023, 3, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(422), new DateTime(2025, 4, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(423), 4, 1 },
                    { 421, new DateTime(2023, 3, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 1, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(425), 5, 2 },
                    { 422, new DateTime(2022, 9, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(427), new DateTime(2025, 4, 11, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(428), 7, 1 },
                    { 423, new DateTime(2022, 4, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(430), new DateTime(2025, 8, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(431), 9, 1 },
                    { 424, new DateTime(2023, 1, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(433), new DateTime(2022, 8, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(434), 1, 2 },
                    { 425, new DateTime(2022, 10, 11, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(437), new DateTime(2024, 9, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(438), 7, 1 },
                    { 426, new DateTime(2022, 7, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(439), new DateTime(2025, 3, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(440), 8, 1 },
                    { 427, new DateTime(2023, 6, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(443), new DateTime(2024, 7, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(443), 2, 1 },
                    { 428, new DateTime(2023, 1, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(445), new DateTime(2024, 11, 15, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(446), 1, 1 },
                    { 429, new DateTime(2023, 1, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(448), new DateTime(2024, 12, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(449), 4, 3 },
                    { 430, new DateTime(2022, 12, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(451), new DateTime(2024, 8, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(452), 1, 1 },
                    { 431, new DateTime(2023, 5, 11, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(454), new DateTime(2025, 4, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(455), 3, 1 },
                    { 432, new DateTime(2022, 2, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(457), new DateTime(2024, 11, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(458), 4, 1 },
                    { 433, new DateTime(2022, 9, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(460), new DateTime(2025, 2, 27, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(461), 6, 1 },
                    { 434, new DateTime(2022, 10, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(463), new DateTime(2025, 8, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(464), 9, 1 },
                    { 435, new DateTime(2022, 10, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(466), new DateTime(2024, 8, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(466), 6, 3 },
                    { 436, new DateTime(2022, 11, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(469), new DateTime(2025, 1, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(470), 1, 1 },
                    { 437, new DateTime(2023, 4, 14, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(472), new DateTime(2024, 11, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(472), 3, 1 },
                    { 438, new DateTime(2022, 8, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(474), new DateTime(2024, 3, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(475), 7, 1 },
                    { 439, new DateTime(2022, 12, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(477), new DateTime(2025, 6, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(478), 8, 1 },
                    { 440, new DateTime(2023, 9, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(480), new DateTime(2025, 2, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(481), 9, 1 },
                    { 441, new DateTime(2023, 2, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(483), new DateTime(2025, 3, 11, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(484), 6, 1 },
                    { 442, new DateTime(2022, 3, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 9, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(487), 8, 1 },
                    { 443, new DateTime(2022, 9, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 6, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(490), 5, 1 },
                    { 444, new DateTime(2022, 5, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(492), new DateTime(2024, 12, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(493), 7, 1 },
                    { 445, new DateTime(2023, 5, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(495), new DateTime(2024, 11, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(495), 5, 1 },
                    { 446, new DateTime(2023, 1, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(497), new DateTime(2024, 4, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(498), 6, 1 },
                    { 447, new DateTime(2022, 3, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(500), new DateTime(2025, 2, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(501), 7, 1 },
                    { 448, new DateTime(2022, 3, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(503), new DateTime(2023, 12, 23, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(504), 8, 1 },
                    { 449, new DateTime(2022, 11, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(506), new DateTime(2022, 12, 15, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(507), 5, 2 },
                    { 450, new DateTime(2022, 11, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(509), new DateTime(2024, 7, 23, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(510), 3, 3 },
                    { 451, new DateTime(2023, 1, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 5, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(513), 9, 1 },
                    { 452, new DateTime(2023, 3, 11, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 2, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(516), 1, 1 },
                    { 453, new DateTime(2022, 7, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(518), new DateTime(2022, 8, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(519), 4, 2 },
                    { 454, new DateTime(2022, 7, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(521), new DateTime(2024, 8, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(522), 9, 1 },
                    { 455, new DateTime(2022, 12, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 11, 23, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(525), 7, 1 },
                    { 456, new DateTime(2022, 7, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 4, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(528), 1, 1 },
                    { 457, new DateTime(2022, 10, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 8, 22, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(530), 8, 1 },
                    { 458, new DateTime(2023, 6, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(551), new DateTime(2024, 7, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(552), 6, 1 },
                    { 459, new DateTime(2022, 12, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(554), new DateTime(2025, 4, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(554), 2, 1 },
                    { 460, new DateTime(2022, 12, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(557), new DateTime(2025, 4, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(558), 5, 3 },
                    { 461, new DateTime(2022, 7, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 1, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(561), 5, 1 },
                    { 462, new DateTime(2022, 3, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 9, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(564), 7, 3 },
                    { 463, new DateTime(2023, 8, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(566), new DateTime(2024, 8, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(567), 9, 1 },
                    { 464, new DateTime(2022, 8, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(569), new DateTime(2024, 5, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(570), 9, 1 },
                    { 465, new DateTime(2022, 11, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(572), new DateTime(2023, 12, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(573), 5, 1 },
                    { 466, new DateTime(2022, 10, 23, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(575), new DateTime(2024, 9, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(576), 9, 1 },
                    { 467, new DateTime(2023, 5, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(578), new DateTime(2024, 8, 15, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(579), 6, 1 },
                    { 468, new DateTime(2022, 10, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(580), new DateTime(2024, 5, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(581), 5, 1 },
                    { 469, new DateTime(2022, 12, 16, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(583), new DateTime(2024, 6, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(584), 3, 1 },
                    { 470, new DateTime(2022, 12, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(586), new DateTime(2024, 10, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(587), 2, 1 },
                    { 471, new DateTime(2022, 12, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(589), new DateTime(2024, 9, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(590), 8, 1 },
                    { 472, new DateTime(2022, 9, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(592), new DateTime(2024, 1, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(593), 5, 1 },
                    { 473, new DateTime(2023, 4, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(595), new DateTime(2024, 8, 3, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(596), 4, 1 },
                    { 474, new DateTime(2022, 9, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(598), new DateTime(2025, 5, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(599), 6, 1 },
                    { 475, new DateTime(2023, 2, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 12, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(601), 7, 1 },
                    { 476, new DateTime(2022, 3, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(603), new DateTime(2024, 11, 15, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(604), 3, 1 },
                    { 477, new DateTime(2022, 9, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(606), new DateTime(2024, 8, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(607), 6, 3 },
                    { 478, new DateTime(2023, 5, 31, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(609), new DateTime(2025, 7, 14, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(610), 1, 1 },
                    { 479, new DateTime(2023, 4, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 7, 4, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(613), 9, 3 },
                    { 480, new DateTime(2022, 10, 5, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(616), new DateTime(2024, 10, 12, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(617), 6, 1 },
                    { 481, new DateTime(2022, 8, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(619), new DateTime(2022, 6, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(620), 6, 2 },
                    { 482, new DateTime(2022, 7, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(622), new DateTime(2023, 11, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(623), 7, 1 },
                    { 483, new DateTime(2022, 11, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(625), new DateTime(2024, 9, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(626), 3, 1 },
                    { 484, new DateTime(2022, 7, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(628), new DateTime(2023, 4, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(629), 1, 2 },
                    { 485, new DateTime(2022, 7, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 9, 10, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(632), 8, 1 },
                    { 486, new DateTime(2022, 8, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 11, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(635), 5, 3 },
                    { 487, new DateTime(2022, 4, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(637), new DateTime(2024, 9, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(638), 8, 1 },
                    { 488, new DateTime(2023, 4, 23, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(640), new DateTime(2025, 2, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(641), 3, 1 },
                    { 489, new DateTime(2022, 10, 1, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 9, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(644), 6, 1 },
                    { 490, new DateTime(2022, 7, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(646), new DateTime(2024, 5, 25, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(647), 2, 1 },
                    { 491, new DateTime(2023, 7, 28, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(649), new DateTime(2024, 2, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(650), 2, 3 },
                    { 492, new DateTime(2022, 11, 7, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(652), new DateTime(2025, 3, 30, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(653), 8, 1 },
                    { 493, new DateTime(2022, 1, 2, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(655), new DateTime(2024, 12, 18, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(656), 5, 1 },
                    { 494, new DateTime(2022, 12, 24, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(658), new DateTime(2025, 1, 26, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(659), 6, 1 },
                    { 495, new DateTime(2022, 6, 8, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(661), new DateTime(2024, 4, 21, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(662), 3, 1 },
                    { 496, new DateTime(2022, 11, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(664), new DateTime(2023, 2, 20, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(665), 3, 2 },
                    { 497, new DateTime(2022, 5, 19, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(667), new DateTime(2023, 2, 17, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(668), 9, 2 },
                    { 498, new DateTime(2022, 4, 6, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 5, 29, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(671), 3, 1 },
                    { 499, new DateTime(2022, 7, 13, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(673), new DateTime(2024, 4, 9, 11, 38, 9, 261, DateTimeKind.Local).AddTicks(674), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "sale",
                columns: new[] { "idPk", "employeeId", "personId", "saledate" },
                values: new object[,]
                {
                    { 1, 2, 8, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 6, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, 10, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 5, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, 6, new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 7, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, 7, new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 5, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, 9, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, 6, new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 2, 6, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 3, 5, new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, 7, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, 8, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, 9, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, 8, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, 8, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 3, 9, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, 10, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 3, 8, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 3, 6, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 3, 10, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 1, 10, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 3, 10, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 2, 9, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 3, 9, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 2, 10, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 3, 5, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 2, 8, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 2, 10, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 1, 8, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 3, 6, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 1, 6, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 1, 6, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 1, 10, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 1, 8, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 3, 5, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 1, 8, new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 2, 9, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 3, 6, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 2, 8, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 3, 7, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 1, 6, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 2, 5, new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 2, 6, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 2, 5, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 3, 10, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 3, 6, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 1, 7, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 3, 6, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 2, 7, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 2, 6, new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 1, 6, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 1, 8, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 2, 10, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 3, 9, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 2, 7, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 3, 9, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 2, 9, new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 1, 10, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 2, 6, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 3, 9, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 3, 5, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 3, 9, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 3, 9, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 3, 8, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 3, 7, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 3, 8, new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 2, 6, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 2, 7, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 1, 6, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 1, 8, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 1, 10, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 3, 6, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 2, 10, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 2, 10, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 2, 7, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 1, 8, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 2, 10, new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 3, 10, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 2, 5, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 1, 8, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 1, 5, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 3, 10, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 3, 6, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 2, 5, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 2, 7, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 2, 5, new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 2, 7, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 3, 6, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 3, 6, new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 2, 10, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 3, 6, new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 3, 5, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 2, 5, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 3, 10, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 3, 9, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 1, 6, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 3, 8, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 2, 5, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, 3, 6, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 2, 10, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, 2, 10, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, 2, 7, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, 2, 6, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, 1, 5, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, 2, 5, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, 1, 9, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, 1, 7, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, 3, 8, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, 1, 5, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, 3, 7, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, 3, 5, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, 1, 10, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, 1, 6, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, 1, 6, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, 1, 8, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, 1, 5, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, 3, 6, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, 2, 6, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, 1, 8, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, 3, 6, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, 2, 5, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, 1, 5, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, 2, 10, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, 2, 5, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, 3, 7, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, 1, 8, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, 2, 6, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, 1, 6, new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "shopping",
                columns: new[] { "idPk", "employeeId", "shoppingDate", "supplierId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 3, new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 2, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 1, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, 1, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, 1, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, 1, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, 3, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, 3, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, 3, new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, 1, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, 3, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, 1, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, 2, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, 2, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, 3, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, 1, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 19, 1, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, 3, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, 3, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, 2, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, 2, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 24, 3, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 25, 3, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 26, 3, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 27, 1, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, 3, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 29, 2, new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 30, 1, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 31, 2, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 32, 3, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 33, 1, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 34, 1, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 35, 2, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, 1, new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 37, 2, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, 1, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 39, 1, new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, 2, new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 41, 1, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, 3, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 44, 2, new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 45, 3, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, 1, new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 47, 1, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, 1, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 49, 2, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 50, 1, new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 51, 2, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 52, 1, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 53, 3, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 54, 3, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 55, 3, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 56, 3, new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 57, 2, new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 58, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 59, 1, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 60, 1, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 61, 1, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 62, 2, new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 63, 1, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 64, 3, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 65, 3, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 66, 3, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 67, 2, new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 68, 2, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 69, 2, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 70, 1, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 71, 1, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 72, 3, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 73, 3, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 74, 1, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 75, 1, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 76, 2, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 77, 1, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 78, 3, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 79, 2, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 80, 3, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 81, 2, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 82, 2, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 83, 2, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 84, 2, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 85, 1, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 86, 1, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 87, 2, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 88, 2, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 89, 2, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 90, 2, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 91, 2, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 92, 2, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 93, 2, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 94, 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 95, 1, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 96, 2, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 97, 1, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 98, 3, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 99, 1, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 100, 3, new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 101, 1, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 102, 2, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 103, 2, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 104, 1, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 105, 3, new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 106, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 107, 1, new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 108, 1, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 109, 2, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 110, 2, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 111, 3, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 112, 1, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 113, 2, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 114, 1, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 115, 1, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 116, 2, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 117, 1, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 118, 3, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 119, 3, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 120, 1, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 121, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 122, 2, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 123, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 124, 3, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 125, 2, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 126, 2, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 127, 2, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 128, 3, new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 129, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 130, 3, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "saleDetail",
                columns: new[] { "MedicineId", "SaleId" },
                values: new object[,]
                {
                    { 1, 67 },
                    { 2, 111 },
                    { 3, 29 },
                    { 4, 7 },
                    { 5, 60 },
                    { 6, 66 },
                    { 7, 61 },
                    { 8, 111 },
                    { 9, 15 },
                    { 10, 20 },
                    { 11, 59 },
                    { 12, 128 },
                    { 13, 88 },
                    { 14, 106 },
                    { 15, 58 },
                    { 16, 77 },
                    { 17, 99 },
                    { 18, 31 },
                    { 19, 93 },
                    { 20, 105 },
                    { 21, 4 },
                    { 22, 97 },
                    { 23, 98 },
                    { 24, 127 },
                    { 25, 61 },
                    { 26, 97 },
                    { 27, 103 },
                    { 28, 73 },
                    { 29, 48 },
                    { 30, 38 },
                    { 31, 61 },
                    { 32, 12 },
                    { 33, 95 },
                    { 34, 98 },
                    { 35, 56 },
                    { 36, 85 },
                    { 37, 57 },
                    { 38, 54 },
                    { 39, 57 },
                    { 40, 100 },
                    { 41, 117 },
                    { 42, 56 },
                    { 43, 64 },
                    { 44, 4 },
                    { 45, 57 },
                    { 46, 100 },
                    { 47, 127 },
                    { 48, 69 },
                    { 49, 3 },
                    { 50, 93 },
                    { 51, 66 },
                    { 52, 88 },
                    { 53, 14 },
                    { 54, 54 },
                    { 55, 111 },
                    { 56, 44 },
                    { 57, 6 },
                    { 58, 122 },
                    { 59, 59 },
                    { 60, 56 },
                    { 61, 51 },
                    { 62, 34 },
                    { 63, 63 },
                    { 64, 128 },
                    { 65, 73 },
                    { 66, 85 },
                    { 67, 127 },
                    { 68, 58 },
                    { 69, 13 },
                    { 70, 78 },
                    { 71, 65 },
                    { 72, 5 },
                    { 73, 86 },
                    { 74, 2 },
                    { 75, 64 },
                    { 76, 127 },
                    { 77, 27 },
                    { 78, 84 },
                    { 79, 38 },
                    { 80, 4 },
                    { 81, 13 },
                    { 82, 28 },
                    { 83, 129 },
                    { 84, 22 },
                    { 85, 46 },
                    { 86, 85 },
                    { 87, 126 },
                    { 88, 40 },
                    { 89, 76 },
                    { 90, 3 },
                    { 91, 53 },
                    { 92, 100 },
                    { 93, 101 },
                    { 94, 98 },
                    { 95, 91 },
                    { 96, 67 },
                    { 97, 59 },
                    { 98, 85 },
                    { 99, 55 },
                    { 100, 53 },
                    { 101, 115 }
                });

            migrationBuilder.InsertData(
                table: "shoppingDetail",
                columns: new[] { "MedicineId", "ShoppingId" },
                values: new object[,]
                {
                    { 1, 75 },
                    { 2, 37 },
                    { 3, 37 },
                    { 4, 83 },
                    { 5, 91 },
                    { 6, 16 },
                    { 7, 64 },
                    { 8, 91 },
                    { 9, 53 },
                    { 10, 68 },
                    { 11, 127 },
                    { 12, 84 },
                    { 13, 34 },
                    { 14, 11 },
                    { 15, 26 },
                    { 16, 19 },
                    { 17, 36 },
                    { 18, 49 },
                    { 19, 75 },
                    { 20, 86 },
                    { 21, 35 },
                    { 22, 109 },
                    { 23, 7 },
                    { 24, 37 },
                    { 25, 52 },
                    { 26, 53 },
                    { 27, 120 },
                    { 28, 61 },
                    { 29, 36 },
                    { 30, 75 },
                    { 31, 44 },
                    { 32, 19 },
                    { 33, 108 },
                    { 34, 64 },
                    { 35, 65 },
                    { 36, 30 },
                    { 37, 85 },
                    { 38, 42 },
                    { 39, 41 },
                    { 40, 103 },
                    { 41, 51 },
                    { 42, 126 },
                    { 43, 57 },
                    { 44, 56 },
                    { 45, 96 },
                    { 46, 60 },
                    { 47, 48 },
                    { 48, 54 },
                    { 49, 33 },
                    { 50, 12 },
                    { 51, 103 },
                    { 52, 43 },
                    { 53, 86 },
                    { 54, 112 },
                    { 55, 129 },
                    { 56, 20 },
                    { 57, 60 },
                    { 58, 126 },
                    { 59, 106 },
                    { 60, 59 },
                    { 61, 74 },
                    { 62, 19 },
                    { 63, 24 },
                    { 64, 41 },
                    { 65, 102 },
                    { 66, 68 },
                    { 67, 55 },
                    { 68, 2 },
                    { 69, 60 },
                    { 70, 108 },
                    { 71, 71 },
                    { 72, 10 },
                    { 73, 83 },
                    { 74, 122 },
                    { 75, 11 },
                    { 76, 96 },
                    { 77, 123 },
                    { 78, 26 },
                    { 79, 129 },
                    { 80, 19 },
                    { 81, 14 },
                    { 82, 47 },
                    { 83, 20 },
                    { 84, 80 },
                    { 85, 121 },
                    { 86, 113 },
                    { 87, 1 },
                    { 88, 83 },
                    { 89, 121 },
                    { 90, 52 },
                    { 91, 97 },
                    { 92, 61 },
                    { 93, 103 },
                    { 94, 17 },
                    { 95, 126 },
                    { 96, 6 },
                    { 97, 94 },
                    { 98, 37 },
                    { 99, 54 },
                    { 100, 128 },
                    { 101, 13 },
                    { 102, 103 },
                    { 103, 89 },
                    { 104, 94 },
                    { 105, 116 },
                    { 106, 121 },
                    { 107, 26 },
                    { 108, 49 },
                    { 109, 70 },
                    { 110, 87 },
                    { 111, 108 },
                    { 112, 45 },
                    { 113, 18 },
                    { 114, 2 },
                    { 115, 12 },
                    { 116, 84 },
                    { 117, 125 },
                    { 118, 98 },
                    { 119, 50 },
                    { 120, 95 },
                    { 121, 56 },
                    { 122, 90 },
                    { 123, 60 },
                    { 124, 67 },
                    { 125, 118 },
                    { 126, 22 },
                    { 127, 98 },
                    { 128, 129 },
                    { 129, 52 },
                    { 130, 118 },
                    { 131, 99 },
                    { 132, 128 },
                    { 133, 34 },
                    { 134, 62 },
                    { 135, 121 },
                    { 136, 91 },
                    { 137, 113 },
                    { 138, 4 },
                    { 139, 56 },
                    { 140, 33 },
                    { 141, 76 },
                    { 142, 61 },
                    { 143, 6 },
                    { 144, 122 },
                    { 145, 55 },
                    { 146, 128 },
                    { 147, 46 },
                    { 148, 95 },
                    { 149, 79 },
                    { 150, 86 },
                    { 151, 72 },
                    { 152, 22 },
                    { 153, 25 },
                    { 154, 109 },
                    { 155, 5 },
                    { 156, 14 },
                    { 157, 6 },
                    { 158, 111 },
                    { 159, 22 },
                    { 160, 27 },
                    { 161, 91 },
                    { 162, 78 },
                    { 163, 108 },
                    { 164, 103 },
                    { 165, 57 },
                    { 166, 76 },
                    { 167, 52 },
                    { 168, 89 },
                    { 169, 75 },
                    { 170, 39 },
                    { 171, 34 },
                    { 172, 61 },
                    { 173, 14 },
                    { 174, 114 },
                    { 175, 122 },
                    { 176, 103 },
                    { 177, 15 },
                    { 178, 62 },
                    { 179, 48 },
                    { 180, 25 },
                    { 181, 97 },
                    { 182, 79 },
                    { 183, 77 },
                    { 184, 2 },
                    { 185, 79 },
                    { 186, 100 },
                    { 187, 74 },
                    { 188, 8 },
                    { 189, 61 },
                    { 190, 46 },
                    { 191, 71 },
                    { 192, 44 },
                    { 193, 76 },
                    { 194, 48 },
                    { 195, 68 },
                    { 196, 85 },
                    { 197, 94 },
                    { 198, 113 },
                    { 199, 68 },
                    { 200, 127 },
                    { 201, 1 },
                    { 202, 127 },
                    { 203, 44 },
                    { 204, 119 },
                    { 205, 45 },
                    { 206, 78 },
                    { 207, 120 },
                    { 208, 45 },
                    { 209, 100 },
                    { 210, 121 },
                    { 211, 56 },
                    { 212, 71 },
                    { 213, 47 },
                    { 214, 69 },
                    { 215, 64 },
                    { 216, 101 },
                    { 217, 128 },
                    { 218, 15 },
                    { 219, 28 },
                    { 220, 52 },
                    { 221, 14 },
                    { 222, 87 },
                    { 223, 36 },
                    { 224, 59 },
                    { 225, 61 },
                    { 226, 116 },
                    { 227, 107 },
                    { 228, 84 },
                    { 229, 83 },
                    { 230, 89 },
                    { 231, 13 },
                    { 232, 2 },
                    { 233, 37 },
                    { 234, 60 },
                    { 235, 56 },
                    { 236, 65 },
                    { 237, 106 },
                    { 238, 103 },
                    { 239, 99 },
                    { 240, 36 },
                    { 241, 54 },
                    { 242, 3 },
                    { 243, 77 },
                    { 244, 64 },
                    { 245, 35 },
                    { 246, 128 },
                    { 247, 119 },
                    { 248, 19 },
                    { 249, 40 },
                    { 250, 108 },
                    { 251, 20 },
                    { 252, 33 },
                    { 253, 43 },
                    { 254, 27 },
                    { 255, 101 },
                    { 256, 120 },
                    { 257, 41 },
                    { 258, 91 },
                    { 259, 21 },
                    { 260, 27 },
                    { 261, 124 },
                    { 262, 29 },
                    { 263, 60 },
                    { 264, 8 },
                    { 265, 53 },
                    { 266, 23 },
                    { 267, 96 },
                    { 268, 57 },
                    { 269, 62 },
                    { 270, 82 },
                    { 271, 108 },
                    { 272, 81 },
                    { 273, 45 },
                    { 274, 41 },
                    { 275, 105 },
                    { 276, 85 },
                    { 277, 22 },
                    { 278, 26 },
                    { 279, 94 },
                    { 280, 84 },
                    { 281, 48 },
                    { 282, 114 },
                    { 283, 88 },
                    { 284, 66 },
                    { 285, 28 },
                    { 286, 21 },
                    { 287, 60 },
                    { 288, 78 },
                    { 289, 50 },
                    { 290, 24 },
                    { 291, 15 },
                    { 292, 78 },
                    { 293, 108 },
                    { 294, 2 },
                    { 295, 55 },
                    { 296, 76 },
                    { 297, 106 },
                    { 298, 33 },
                    { 299, 41 },
                    { 300, 88 },
                    { 301, 110 },
                    { 302, 96 },
                    { 303, 67 },
                    { 304, 30 },
                    { 305, 95 },
                    { 306, 59 },
                    { 307, 28 },
                    { 308, 125 },
                    { 309, 16 },
                    { 310, 72 },
                    { 311, 67 },
                    { 312, 91 },
                    { 313, 110 },
                    { 314, 37 },
                    { 315, 117 },
                    { 316, 80 },
                    { 317, 100 },
                    { 318, 9 },
                    { 319, 126 },
                    { 320, 1 },
                    { 321, 122 },
                    { 322, 2 },
                    { 323, 71 },
                    { 324, 36 },
                    { 325, 5 },
                    { 326, 98 },
                    { 327, 86 },
                    { 328, 33 },
                    { 329, 19 },
                    { 330, 102 },
                    { 331, 65 },
                    { 332, 32 },
                    { 333, 47 },
                    { 334, 119 },
                    { 335, 56 },
                    { 336, 12 },
                    { 337, 10 },
                    { 338, 108 },
                    { 339, 38 },
                    { 340, 101 },
                    { 341, 44 },
                    { 342, 42 },
                    { 343, 67 },
                    { 344, 57 },
                    { 345, 117 },
                    { 346, 69 },
                    { 347, 60 },
                    { 348, 26 },
                    { 349, 101 },
                    { 350, 36 },
                    { 351, 56 },
                    { 352, 86 },
                    { 353, 49 },
                    { 354, 16 },
                    { 355, 78 },
                    { 356, 40 },
                    { 357, 31 },
                    { 358, 16 },
                    { 359, 41 },
                    { 360, 1 },
                    { 361, 52 },
                    { 362, 31 },
                    { 363, 94 },
                    { 364, 57 },
                    { 365, 21 },
                    { 366, 64 },
                    { 367, 84 },
                    { 368, 65 },
                    { 369, 122 },
                    { 370, 30 },
                    { 371, 61 },
                    { 372, 44 },
                    { 373, 129 },
                    { 374, 24 },
                    { 375, 39 },
                    { 376, 59 },
                    { 377, 68 },
                    { 378, 115 },
                    { 379, 103 },
                    { 380, 102 },
                    { 381, 79 },
                    { 382, 90 },
                    { 383, 73 },
                    { 384, 91 },
                    { 385, 113 },
                    { 386, 111 },
                    { 387, 28 },
                    { 388, 74 },
                    { 389, 102 },
                    { 390, 96 },
                    { 391, 52 },
                    { 392, 107 },
                    { 393, 57 },
                    { 394, 31 },
                    { 395, 33 },
                    { 396, 75 },
                    { 397, 61 },
                    { 398, 124 },
                    { 399, 102 },
                    { 400, 92 },
                    { 401, 103 },
                    { 402, 56 },
                    { 403, 87 },
                    { 404, 99 },
                    { 405, 95 },
                    { 406, 79 },
                    { 407, 101 },
                    { 408, 42 },
                    { 409, 54 },
                    { 410, 65 },
                    { 411, 46 },
                    { 412, 49 },
                    { 413, 20 },
                    { 414, 44 },
                    { 415, 5 },
                    { 416, 80 },
                    { 417, 86 },
                    { 418, 14 },
                    { 419, 88 },
                    { 420, 52 },
                    { 421, 92 },
                    { 422, 19 },
                    { 423, 13 },
                    { 424, 114 },
                    { 425, 75 },
                    { 426, 123 },
                    { 427, 53 },
                    { 428, 99 },
                    { 429, 51 },
                    { 430, 38 },
                    { 431, 124 },
                    { 432, 90 },
                    { 433, 112 },
                    { 434, 41 },
                    { 435, 120 },
                    { 436, 92 },
                    { 437, 118 },
                    { 438, 81 },
                    { 439, 112 },
                    { 440, 6 },
                    { 441, 24 },
                    { 442, 95 },
                    { 443, 114 },
                    { 444, 82 },
                    { 445, 69 },
                    { 446, 40 },
                    { 447, 63 },
                    { 448, 123 },
                    { 449, 77 },
                    { 450, 76 },
                    { 451, 116 },
                    { 452, 103 },
                    { 453, 55 },
                    { 454, 79 },
                    { 455, 104 },
                    { 456, 46 },
                    { 457, 59 },
                    { 458, 50 },
                    { 459, 91 },
                    { 460, 125 },
                    { 461, 55 },
                    { 462, 86 },
                    { 463, 55 },
                    { 464, 33 },
                    { 465, 102 },
                    { 466, 108 },
                    { 467, 75 },
                    { 468, 85 },
                    { 469, 2 },
                    { 470, 103 },
                    { 471, 90 },
                    { 472, 62 },
                    { 473, 97 },
                    { 474, 115 },
                    { 475, 86 },
                    { 476, 68 },
                    { 477, 87 },
                    { 478, 103 },
                    { 479, 27 },
                    { 480, 62 },
                    { 481, 81 },
                    { 482, 49 },
                    { 483, 94 },
                    { 484, 117 },
                    { 485, 58 },
                    { 486, 51 },
                    { 487, 1 },
                    { 488, 84 },
                    { 489, 53 },
                    { 490, 49 },
                    { 491, 104 },
                    { 492, 129 },
                    { 493, 123 },
                    { 494, 44 },
                    { 495, 52 },
                    { 496, 18 },
                    { 497, 42 },
                    { 498, 103 },
                    { 499, 83 }
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
