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
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Employee" },
                    { 3, "Manager" }
                });

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
                    { 1, new DateTime(2023, 9, 29, 7, 10, 1, 313, DateTimeKind.Local).AddTicks(8760), "0000000000", 3, "root", 1, new DateTime(2023, 9, 29, 7, 10, 1, 313, DateTimeKind.Local).AddTicks(8743) },
                    { 2, new DateTime(2023, 9, 29, 7, 10, 1, 313, DateTimeKind.Local).AddTicks(8762), "0000000001", 3, "ProveedorA", 2, new DateTime(2023, 9, 29, 7, 10, 1, 313, DateTimeKind.Local).AddTicks(8761) },
                    { 3, new DateTime(2023, 9, 29, 7, 10, 1, 313, DateTimeKind.Local).AddTicks(8763), "0000000002", 3, "ProveedorB", 2, new DateTime(2023, 9, 29, 7, 10, 1, 313, DateTimeKind.Local).AddTicks(8762) },
                    { 4, new DateTime(2023, 9, 29, 7, 10, 1, 313, DateTimeKind.Local).AddTicks(8765), "0000000003", 3, "ProveedorC", 2, new DateTime(2023, 9, 29, 7, 10, 1, 313, DateTimeKind.Local).AddTicks(8765) },
                    { 5, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "546869433", 1, "Juan Paco", 1, new DateTime(2023, 9, 29, 7, 10, 1, 313, DateTimeKind.Local).AddTicks(8766) },
                    { 6, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "546869433", 1, "Pedro De La Mar", 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2014, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "1000354228", 2, "Maria Db", 1, new DateTime(2023, 9, 29, 7, 10, 1, 313, DateTimeKind.Local).AddTicks(8775) },
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
                    { 1, new DateTime(2022, 1, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 1, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4036), 6, 4 },
                    { 2, new DateTime(2022, 9, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4052), new DateTime(2024, 2, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4053), 7, 4 },
                    { 3, new DateTime(2022, 9, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4056), new DateTime(2025, 4, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4058), 1, 4 },
                    { 4, new DateTime(2022, 10, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4061), new DateTime(2024, 6, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4062), 7, 4 },
                    { 5, new DateTime(2023, 6, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4065), new DateTime(2024, 12, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4083), 7, 4 },
                    { 6, new DateTime(2022, 8, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4088), new DateTime(2024, 3, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4090), 1, 4 },
                    { 7, new DateTime(2022, 12, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4093), new DateTime(2023, 10, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4094), 5, 4 },
                    { 8, new DateTime(2023, 3, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4097), new DateTime(2025, 1, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4099), 7, 4 },
                    { 9, new DateTime(2023, 5, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4103), new DateTime(2024, 10, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4104), 2, 3 },
                    { 10, new DateTime(2022, 6, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4113), new DateTime(2025, 2, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4115), 7, 4 },
                    { 11, new DateTime(2022, 5, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4153), new DateTime(2024, 10, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4154), 5, 4 },
                    { 12, new DateTime(2022, 1, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4158), new DateTime(2024, 10, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4159), 2, 4 },
                    { 13, new DateTime(2023, 3, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4162), new DateTime(2025, 5, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4163), 4, 4 },
                    { 14, new DateTime(2022, 2, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4166), new DateTime(2025, 5, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4167), 9, 4 },
                    { 15, new DateTime(2023, 4, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4171), new DateTime(2025, 6, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4172), 9, 4 },
                    { 16, new DateTime(2022, 2, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4198), new DateTime(2025, 4, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4200), 6, 4 },
                    { 17, new DateTime(2023, 4, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4203), new DateTime(2024, 9, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4204), 5, 4 },
                    { 18, new DateTime(2022, 11, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4210), new DateTime(2025, 4, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4211), 9, 4 },
                    { 19, new DateTime(2022, 1, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4214), new DateTime(2024, 7, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4215), 6, 4 },
                    { 20, new DateTime(2022, 10, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4218), new DateTime(2025, 2, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4220), 8, 4 },
                    { 21, new DateTime(2023, 1, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4223), new DateTime(2024, 11, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4224), 3, 4 },
                    { 22, new DateTime(2022, 12, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4227), new DateTime(2024, 4, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4229), 5, 4 },
                    { 23, new DateTime(2021, 11, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 8, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4233), 1, 4 },
                    { 24, new DateTime(2023, 2, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4236), new DateTime(2024, 10, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4237), 9, 4 },
                    { 25, new DateTime(2022, 7, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4240), new DateTime(2024, 6, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4242), 5, 4 },
                    { 26, new DateTime(2022, 9, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4245), new DateTime(2025, 3, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4246), 7, 4 },
                    { 27, new DateTime(2022, 9, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4249), new DateTime(2025, 5, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4251), 5, 3 },
                    { 28, new DateTime(2022, 3, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4254), new DateTime(2024, 11, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4255), 8, 4 },
                    { 29, new DateTime(2022, 12, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4258), new DateTime(2024, 11, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4259), 6, 4 },
                    { 30, new DateTime(2023, 8, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4262), new DateTime(2024, 7, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4263), 4, 4 },
                    { 31, new DateTime(2022, 8, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4270), new DateTime(2025, 2, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4272), 3, 4 },
                    { 32, new DateTime(2022, 3, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4275), new DateTime(2024, 7, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4276), 5, 4 },
                    { 33, new DateTime(2023, 1, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4279), new DateTime(2024, 12, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4280), 6, 4 },
                    { 34, new DateTime(2022, 10, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4284), new DateTime(2024, 11, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4286), 4, 4 },
                    { 35, new DateTime(2022, 7, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4289), new DateTime(2024, 7, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4290), 4, 4 },
                    { 36, new DateTime(2023, 4, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 12, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4294), 7, 4 },
                    { 37, new DateTime(2022, 3, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4297), new DateTime(2025, 7, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4299), 6, 4 },
                    { 38, new DateTime(2022, 1, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4302), new DateTime(2024, 5, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4303), 5, 4 },
                    { 39, new DateTime(2023, 5, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4306), new DateTime(2025, 4, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4307), 3, 4 },
                    { 40, new DateTime(2023, 5, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4310), new DateTime(2024, 2, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4312), 9, 4 },
                    { 41, new DateTime(2022, 10, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4315), new DateTime(2024, 8, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4316), 7, 4 },
                    { 42, new DateTime(2022, 2, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4319), new DateTime(2024, 2, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4320), 6, 4 },
                    { 43, new DateTime(2023, 6, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4323), new DateTime(2024, 9, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4325), 9, 4 },
                    { 44, new DateTime(2022, 6, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4328), new DateTime(2024, 6, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4329), 3, 4 },
                    { 45, new DateTime(2022, 7, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4332), new DateTime(2024, 11, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4334), 8, 4 },
                    { 46, new DateTime(2023, 1, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4336), new DateTime(2024, 9, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4338), 1, 4 },
                    { 47, new DateTime(2022, 7, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4341), new DateTime(2024, 2, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4342), 3, 4 },
                    { 48, new DateTime(2022, 10, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4345), new DateTime(2024, 12, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4346), 8, 4 },
                    { 49, new DateTime(2023, 2, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4349), new DateTime(2024, 7, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4350), 8, 3 },
                    { 50, new DateTime(2022, 6, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4353), new DateTime(2024, 4, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4355), 4, 4 },
                    { 51, new DateTime(2022, 5, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4359), new DateTime(2025, 1, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4360), 1, 4 },
                    { 52, new DateTime(2023, 2, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4365), new DateTime(2023, 12, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4366), 9, 4 },
                    { 53, new DateTime(2021, 11, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4369), new DateTime(2024, 5, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4371), 6, 4 },
                    { 54, new DateTime(2023, 4, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4374), new DateTime(2025, 3, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4375), 5, 4 },
                    { 55, new DateTime(2022, 6, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4378), new DateTime(2024, 10, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4379), 4, 4 },
                    { 56, new DateTime(2022, 10, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4382), new DateTime(2025, 2, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4384), 9, 3 },
                    { 57, new DateTime(2022, 7, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4387), new DateTime(2024, 11, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4388), 2, 4 },
                    { 58, new DateTime(2023, 1, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4391), new DateTime(2024, 12, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4392), 3, 4 },
                    { 59, new DateTime(2022, 12, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4395), new DateTime(2022, 7, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4396), 3, 2 },
                    { 60, new DateTime(2022, 7, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4399), new DateTime(2025, 2, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4401), 9, 4 },
                    { 61, new DateTime(2022, 8, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4404), new DateTime(2024, 6, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4406), 8, 4 },
                    { 62, new DateTime(2022, 11, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4409), new DateTime(2023, 12, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4410), 8, 4 },
                    { 63, new DateTime(2021, 11, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 9, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4415), 3, 4 },
                    { 64, new DateTime(2022, 10, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4475), new DateTime(2025, 2, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4477), 1, 4 },
                    { 65, new DateTime(2023, 1, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4480), new DateTime(2024, 12, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4482), 3, 4 },
                    { 66, new DateTime(2022, 6, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4486), new DateTime(2025, 1, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4487), 8, 4 },
                    { 67, new DateTime(2023, 5, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 4, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4491), 3, 4 },
                    { 68, new DateTime(2022, 7, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4494), new DateTime(2024, 8, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4496), 8, 4 },
                    { 69, new DateTime(2022, 8, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4499), new DateTime(2024, 9, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4500), 3, 4 },
                    { 70, new DateTime(2022, 9, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4503), new DateTime(2024, 8, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4504), 4, 3 },
                    { 71, new DateTime(2022, 4, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 8, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4509), 2, 4 },
                    { 72, new DateTime(2023, 2, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4511), new DateTime(2024, 10, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4513), 7, 4 },
                    { 73, new DateTime(2023, 5, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4515), new DateTime(2024, 5, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4517), 6, 4 },
                    { 74, new DateTime(2023, 5, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4520), new DateTime(2023, 1, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4521), 1, 2 },
                    { 75, new DateTime(2023, 8, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4524), new DateTime(2024, 12, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4525), 2, 4 },
                    { 76, new DateTime(2022, 8, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4528), new DateTime(2024, 4, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4529), 4, 4 },
                    { 77, new DateTime(2022, 12, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4532), new DateTime(2023, 1, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4533), 8, 2 },
                    { 78, new DateTime(2022, 12, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4536), new DateTime(2024, 12, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4537), 2, 4 },
                    { 79, new DateTime(2022, 5, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4540), new DateTime(2025, 3, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4542), 6, 4 },
                    { 80, new DateTime(2022, 12, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4545), new DateTime(2024, 4, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4546), 5, 4 },
                    { 81, new DateTime(2023, 2, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4549), new DateTime(2025, 1, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4550), 2, 4 },
                    { 82, new DateTime(2022, 9, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4553), new DateTime(2024, 10, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4554), 7, 3 },
                    { 83, new DateTime(2022, 9, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4557), new DateTime(2024, 9, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4559), 2, 4 },
                    { 84, new DateTime(2022, 6, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4562), new DateTime(2024, 6, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4563), 1, 4 },
                    { 85, new DateTime(2023, 7, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4566), new DateTime(2024, 6, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4568), 9, 4 },
                    { 86, new DateTime(2022, 6, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4571), new DateTime(2025, 4, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4572), 4, 3 },
                    { 87, new DateTime(2022, 10, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4575), new DateTime(2024, 7, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4576), 9, 3 },
                    { 88, new DateTime(2022, 7, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4579), new DateTime(2024, 9, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4581), 3, 3 },
                    { 89, new DateTime(2022, 6, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4583), new DateTime(2024, 1, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4585), 2, 4 },
                    { 90, new DateTime(2022, 11, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 6, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4589), 3, 4 },
                    { 91, new DateTime(2022, 8, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 12, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4593), 8, 4 },
                    { 92, new DateTime(2021, 12, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 12, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4597), 3, 4 },
                    { 93, new DateTime(2023, 2, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4600), new DateTime(2024, 4, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4601), 6, 4 },
                    { 94, new DateTime(2023, 2, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 9, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4605), 1, 4 },
                    { 95, new DateTime(2023, 8, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4608), new DateTime(2024, 3, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4609), 2, 4 },
                    { 96, new DateTime(2022, 10, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4612), new DateTime(2025, 7, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4614), 4, 4 },
                    { 97, new DateTime(2022, 9, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4616), new DateTime(2025, 2, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4618), 8, 3 },
                    { 98, new DateTime(2022, 7, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4621), new DateTime(2023, 3, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4622), 9, 2 },
                    { 99, new DateTime(2023, 8, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4625), new DateTime(2024, 8, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4626), 3, 4 },
                    { 100, new DateTime(2022, 8, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4629), new DateTime(2024, 3, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4630), 2, 4 },
                    { 101, new DateTime(2022, 2, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4633), new DateTime(2025, 5, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4634), 5, 4 },
                    { 102, new DateTime(2022, 12, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4637), new DateTime(2024, 8, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4639), 6, 4 },
                    { 103, new DateTime(2022, 6, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4642), new DateTime(2025, 4, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4643), 8, 1 },
                    { 104, new DateTime(2022, 2, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4646), new DateTime(2025, 4, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4647), 2, 3 },
                    { 105, new DateTime(2023, 1, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 9, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4652), 4, 3 },
                    { 106, new DateTime(2023, 1, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4655), new DateTime(2025, 4, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4657), 7, 1 },
                    { 107, new DateTime(2022, 8, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4660), new DateTime(2024, 6, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4661), 9, 1 },
                    { 108, new DateTime(2023, 3, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4664), new DateTime(2023, 6, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4665), 8, 2 },
                    { 109, new DateTime(2022, 10, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 6, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4670), 4, 1 },
                    { 110, new DateTime(2023, 2, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4672), new DateTime(2024, 5, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4674), 2, 1 },
                    { 111, new DateTime(2022, 3, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 8, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4678), 7, 1 },
                    { 112, new DateTime(2022, 6, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4681), new DateTime(2024, 5, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4683), 6, 1 },
                    { 113, new DateTime(2023, 8, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4686), new DateTime(2024, 11, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4687), 6, 3 },
                    { 114, new DateTime(2022, 5, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 11, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4692), 3, 1 },
                    { 115, new DateTime(2022, 5, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 4, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4696), 1, 1 },
                    { 116, new DateTime(2022, 5, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4699), new DateTime(2024, 7, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4700), 6, 1 },
                    { 117, new DateTime(2022, 2, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 12, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4704), 4, 1 },
                    { 118, new DateTime(2022, 12, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4707), new DateTime(2024, 12, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4708), 5, 1 },
                    { 119, new DateTime(2022, 12, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 9, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4712), 2, 1 },
                    { 120, new DateTime(2022, 8, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 6, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4717), 3, 1 },
                    { 121, new DateTime(2022, 4, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4720), new DateTime(2025, 3, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4721), 8, 1 },
                    { 122, new DateTime(2022, 4, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4724), new DateTime(2024, 4, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4726), 9, 1 },
                    { 123, new DateTime(2022, 11, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 6, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4730), 2, 1 },
                    { 124, new DateTime(2022, 10, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4733), new DateTime(2025, 1, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4734), 7, 1 },
                    { 125, new DateTime(2022, 10, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4737), new DateTime(2024, 9, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4738), 4, 3 },
                    { 126, new DateTime(2022, 10, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 11, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4743), 5, 1 },
                    { 127, new DateTime(2023, 3, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4745), new DateTime(2025, 1, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4746), 6, 1 },
                    { 128, new DateTime(2022, 10, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4749), new DateTime(2025, 2, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4751), 9, 1 },
                    { 129, new DateTime(2022, 4, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4754), new DateTime(2024, 5, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4755), 5, 1 },
                    { 130, new DateTime(2022, 10, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4935), new DateTime(2023, 7, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4939), 3, 2 },
                    { 131, new DateTime(2023, 3, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4946), new DateTime(2024, 10, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4947), 8, 1 },
                    { 132, new DateTime(2023, 6, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 6, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4951), 2, 1 },
                    { 133, new DateTime(2022, 11, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4954), new DateTime(2024, 10, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4956), 6, 1 },
                    { 134, new DateTime(2022, 9, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4960), new DateTime(2024, 9, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4961), 9, 1 },
                    { 135, new DateTime(2022, 4, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4964), new DateTime(2022, 6, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4966), 2, 2 },
                    { 136, new DateTime(2023, 2, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4969), new DateTime(2024, 5, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4970), 1, 1 },
                    { 137, new DateTime(2023, 2, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4973), new DateTime(2025, 3, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4974), 7, 1 },
                    { 138, new DateTime(2022, 6, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 5, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4979), 7, 1 },
                    { 139, new DateTime(2022, 5, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4981), new DateTime(2024, 7, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4983), 7, 3 },
                    { 140, new DateTime(2023, 5, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 5, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4987), 5, 1 },
                    { 141, new DateTime(2023, 4, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4990), new DateTime(2024, 7, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4991), 6, 1 },
                    { 142, new DateTime(2023, 4, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4994), new DateTime(2025, 2, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4995), 3, 1 },
                    { 143, new DateTime(2022, 12, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(4998), new DateTime(2023, 8, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5000), 2, 2 },
                    { 144, new DateTime(2022, 11, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5003), new DateTime(2025, 7, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5004), 5, 1 },
                    { 145, new DateTime(2022, 1, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5007), new DateTime(2024, 12, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5008), 5, 1 },
                    { 146, new DateTime(2022, 5, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5011), new DateTime(2024, 9, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5013), 1, 1 },
                    { 147, new DateTime(2022, 7, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5016), new DateTime(2025, 4, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5017), 2, 3 },
                    { 148, new DateTime(2022, 7, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5020), new DateTime(2025, 1, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5022), 5, 1 },
                    { 149, new DateTime(2022, 9, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5024), new DateTime(2024, 10, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5026), 7, 1 },
                    { 150, new DateTime(2022, 3, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5028), new DateTime(2024, 2, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5030), 5, 1 },
                    { 151, new DateTime(2023, 4, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5033), new DateTime(2025, 4, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5034), 8, 1 },
                    { 152, new DateTime(2022, 5, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5037), new DateTime(2025, 1, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5038), 4, 1 },
                    { 153, new DateTime(2023, 5, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5041), new DateTime(2024, 6, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5043), 3, 1 },
                    { 154, new DateTime(2023, 4, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5046), new DateTime(2024, 6, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5047), 5, 1 },
                    { 155, new DateTime(2023, 1, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5050), new DateTime(2025, 3, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5051), 7, 1 },
                    { 156, new DateTime(2023, 1, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5054), new DateTime(2024, 9, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5056), 8, 3 },
                    { 157, new DateTime(2022, 10, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5059), new DateTime(2024, 12, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5060), 7, 1 },
                    { 158, new DateTime(2022, 2, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 2, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5064), 6, 2 },
                    { 159, new DateTime(2021, 12, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5067), new DateTime(2025, 6, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5069), 5, 1 },
                    { 160, new DateTime(2022, 11, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5071), new DateTime(2024, 2, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5073), 4, 1 },
                    { 161, new DateTime(2022, 2, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5076), new DateTime(2024, 4, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5077), 8, 1 },
                    { 162, new DateTime(2022, 3, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5080), new DateTime(2025, 1, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5081), 6, 1 },
                    { 163, new DateTime(2022, 7, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5084), new DateTime(2025, 1, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5085), 7, 1 },
                    { 164, new DateTime(2022, 2, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5089), new DateTime(2024, 11, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5090), 8, 1 },
                    { 165, new DateTime(2022, 12, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5093), new DateTime(2024, 9, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5094), 9, 1 },
                    { 166, new DateTime(2022, 6, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5097), new DateTime(2024, 12, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5098), 7, 1 },
                    { 167, new DateTime(2023, 6, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5101), new DateTime(2025, 2, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5103), 3, 1 },
                    { 168, new DateTime(2022, 9, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5105), new DateTime(2024, 5, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5107), 8, 1 },
                    { 169, new DateTime(2022, 9, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5109), new DateTime(2025, 1, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5111), 9, 1 },
                    { 170, new DateTime(2022, 5, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5114), new DateTime(2024, 10, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5115), 6, 1 },
                    { 171, new DateTime(2022, 6, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 2, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5119), 3, 2 },
                    { 172, new DateTime(2023, 5, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 8, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5124), 1, 1 },
                    { 173, new DateTime(2023, 8, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5127), new DateTime(2025, 2, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5128), 7, 1 },
                    { 174, new DateTime(2023, 2, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5131), new DateTime(2024, 4, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5133), 4, 1 },
                    { 175, new DateTime(2022, 9, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5136), new DateTime(2024, 12, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5137), 6, 1 },
                    { 176, new DateTime(2022, 3, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5140), new DateTime(2024, 10, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5142), 2, 1 },
                    { 177, new DateTime(2022, 7, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5145), new DateTime(2024, 11, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5146), 9, 1 },
                    { 178, new DateTime(2022, 12, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5149), new DateTime(2024, 12, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5150), 8, 1 },
                    { 179, new DateTime(2022, 12, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5153), new DateTime(2025, 1, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5155), 5, 1 },
                    { 180, new DateTime(2022, 4, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5158), new DateTime(2024, 10, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5159), 2, 1 },
                    { 181, new DateTime(2023, 8, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5163), new DateTime(2025, 2, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5164), 8, 1 },
                    { 182, new DateTime(2022, 11, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5167), new DateTime(2024, 9, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5168), 4, 1 },
                    { 183, new DateTime(2023, 6, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5171), new DateTime(2024, 1, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5172), 9, 1 },
                    { 184, new DateTime(2023, 1, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5175), new DateTime(2025, 1, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5176), 9, 1 },
                    { 185, new DateTime(2022, 11, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5179), new DateTime(2024, 12, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5180), 8, 1 },
                    { 186, new DateTime(2022, 10, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5184), new DateTime(2024, 7, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5185), 8, 1 },
                    { 187, new DateTime(2022, 11, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5188), new DateTime(2024, 9, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5189), 7, 1 },
                    { 188, new DateTime(2022, 7, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5192), new DateTime(2024, 12, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5193), 1, 1 },
                    { 189, new DateTime(2022, 11, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5197), new DateTime(2025, 2, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5198), 5, 1 },
                    { 190, new DateTime(2022, 3, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5201), new DateTime(2022, 9, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5202), 9, 2 },
                    { 191, new DateTime(2022, 11, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5205), new DateTime(2025, 2, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5207), 7, 1 },
                    { 192, new DateTime(2022, 11, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5210), new DateTime(2024, 11, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5211), 3, 1 },
                    { 193, new DateTime(2022, 1, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5214), new DateTime(2024, 12, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5215), 4, 1 },
                    { 194, new DateTime(2023, 8, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5218), new DateTime(2024, 6, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5220), 1, 1 },
                    { 195, new DateTime(2022, 11, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5222), new DateTime(2024, 12, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5224), 2, 1 },
                    { 196, new DateTime(2022, 9, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5227), new DateTime(2024, 11, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5228), 9, 1 },
                    { 197, new DateTime(2023, 9, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5231), new DateTime(2025, 4, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5232), 8, 1 },
                    { 198, new DateTime(2023, 5, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5235), new DateTime(2025, 4, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5236), 7, 1 },
                    { 199, new DateTime(2023, 7, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5239), new DateTime(2024, 12, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5240), 6, 1 },
                    { 200, new DateTime(2023, 1, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5243), new DateTime(2022, 7, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5244), 3, 2 },
                    { 201, new DateTime(2022, 8, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5247), new DateTime(2024, 6, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5249), 8, 1 },
                    { 202, new DateTime(2022, 9, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 1, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5427), 8, 2 },
                    { 203, new DateTime(2023, 3, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5430), new DateTime(2024, 7, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5432), 1, 1 },
                    { 204, new DateTime(2023, 3, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5435), new DateTime(2025, 3, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5436), 6, 1 },
                    { 205, new DateTime(2022, 3, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5439), new DateTime(2025, 5, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5440), 4, 1 },
                    { 206, new DateTime(2022, 3, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5443), new DateTime(2024, 11, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5444), 1, 1 },
                    { 207, new DateTime(2023, 8, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5447), new DateTime(2024, 6, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5449), 6, 1 },
                    { 208, new DateTime(2022, 11, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5451), new DateTime(2024, 11, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5453), 5, 1 },
                    { 209, new DateTime(2021, 12, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5455), new DateTime(2023, 12, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5457), 5, 1 },
                    { 210, new DateTime(2022, 10, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5460), new DateTime(2025, 2, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5461), 7, 1 },
                    { 211, new DateTime(2022, 1, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5464), new DateTime(2024, 9, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5466), 1, 1 },
                    { 212, new DateTime(2022, 8, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5469), new DateTime(2024, 6, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5470), 8, 1 },
                    { 213, new DateTime(2022, 3, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5473), new DateTime(2024, 9, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5474), 5, 1 },
                    { 214, new DateTime(2022, 6, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5478), new DateTime(2024, 8, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5479), 4, 1 },
                    { 215, new DateTime(2023, 2, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5482), new DateTime(2024, 7, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5483), 6, 1 },
                    { 216, new DateTime(2022, 12, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5486), new DateTime(2025, 1, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5488), 7, 1 },
                    { 217, new DateTime(2023, 5, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5490), new DateTime(2024, 9, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5492), 7, 1 },
                    { 218, new DateTime(2022, 10, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 9, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5496), 9, 1 },
                    { 219, new DateTime(2022, 4, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5499), new DateTime(2025, 4, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5500), 6, 1 },
                    { 220, new DateTime(2023, 2, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5503), new DateTime(2024, 10, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5504), 8, 1 },
                    { 221, new DateTime(2022, 10, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5507), new DateTime(2024, 1, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5509), 4, 1 },
                    { 222, new DateTime(2022, 10, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5512), new DateTime(2024, 9, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5513), 6, 3 },
                    { 223, new DateTime(2022, 9, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5516), new DateTime(2024, 6, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5518), 3, 1 },
                    { 224, new DateTime(2022, 10, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5520), new DateTime(2024, 9, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5522), 2, 1 },
                    { 225, new DateTime(2023, 1, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5525), new DateTime(2025, 6, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5526), 5, 1 },
                    { 226, new DateTime(2022, 3, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5529), new DateTime(2024, 1, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5531), 5, 1 },
                    { 227, new DateTime(2022, 2, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5534), new DateTime(2025, 1, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5535), 4, 1 },
                    { 228, new DateTime(2023, 2, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5538), new DateTime(2024, 7, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5539), 3, 1 },
                    { 229, new DateTime(2023, 6, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5542), new DateTime(2025, 3, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5544), 3, 1 },
                    { 230, new DateTime(2023, 1, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5547), new DateTime(2023, 1, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5548), 5, 2 },
                    { 231, new DateTime(2022, 7, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 11, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5552), 8, 1 },
                    { 232, new DateTime(2023, 1, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5555), new DateTime(2024, 7, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5557), 9, 1 },
                    { 233, new DateTime(2023, 7, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5559), new DateTime(2022, 10, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5561), 5, 2 },
                    { 234, new DateTime(2022, 7, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5564), new DateTime(2024, 1, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5565), 9, 1 },
                    { 235, new DateTime(2022, 2, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5568), new DateTime(2025, 7, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5569), 8, 3 },
                    { 236, new DateTime(2023, 1, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5572), new DateTime(2024, 7, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5573), 2, 1 },
                    { 237, new DateTime(2022, 7, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 8, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5578), 5, 1 },
                    { 238, new DateTime(2022, 8, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5581), new DateTime(2024, 9, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5582), 1, 1 },
                    { 239, new DateTime(2022, 12, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5585), new DateTime(2024, 12, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5587), 7, 1 },
                    { 240, new DateTime(2023, 1, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 3, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5591), 1, 2 },
                    { 241, new DateTime(2022, 9, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5594), new DateTime(2024, 9, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5595), 7, 1 },
                    { 242, new DateTime(2023, 2, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5598), new DateTime(2024, 6, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5600), 7, 1 },
                    { 243, new DateTime(2023, 7, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5602), new DateTime(2025, 1, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5604), 2, 1 },
                    { 244, new DateTime(2023, 4, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5607), new DateTime(2025, 3, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5608), 1, 1 },
                    { 245, new DateTime(2022, 11, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5611), new DateTime(2024, 7, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5612), 8, 1 },
                    { 246, new DateTime(2023, 4, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5615), new DateTime(2025, 4, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5616), 3, 1 },
                    { 247, new DateTime(2022, 5, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 10, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5620), 9, 1 },
                    { 248, new DateTime(2022, 9, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5623), new DateTime(2024, 12, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5624), 9, 1 },
                    { 249, new DateTime(2022, 5, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5627), new DateTime(2024, 10, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5628), 2, 3 },
                    { 250, new DateTime(2022, 9, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5631), new DateTime(2022, 10, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5632), 1, 2 },
                    { 251, new DateTime(2021, 11, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5636), new DateTime(2024, 11, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5637), 8, 1 },
                    { 252, new DateTime(2023, 3, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 2, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5641), 2, 1 },
                    { 253, new DateTime(2022, 4, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5644), new DateTime(2024, 5, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5645), 1, 1 },
                    { 254, new DateTime(2023, 6, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5648), new DateTime(2024, 9, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5649), 6, 1 },
                    { 255, new DateTime(2022, 12, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5652), new DateTime(2025, 4, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5653), 3, 1 },
                    { 256, new DateTime(2022, 10, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5656), new DateTime(2024, 6, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5657), 2, 1 },
                    { 257, new DateTime(2023, 8, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5660), new DateTime(2025, 6, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5661), 8, 1 },
                    { 258, new DateTime(2022, 6, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 6, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5732), 3, 1 },
                    { 259, new DateTime(2023, 3, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5735), new DateTime(2024, 7, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5736), 6, 1 },
                    { 260, new DateTime(2023, 9, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5739), new DateTime(2023, 12, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5740), 4, 1 },
                    { 261, new DateTime(2022, 11, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5743), new DateTime(2025, 5, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5744), 9, 1 },
                    { 262, new DateTime(2022, 4, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5748), new DateTime(2023, 11, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5749), 5, 1 },
                    { 263, new DateTime(2022, 8, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5753), new DateTime(2025, 6, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5754), 3, 3 },
                    { 264, new DateTime(2022, 8, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5757), new DateTime(2025, 5, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5758), 6, 1 },
                    { 265, new DateTime(2023, 3, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5761), new DateTime(2024, 11, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5762), 7, 1 },
                    { 266, new DateTime(2022, 6, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5765), new DateTime(2024, 12, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5766), 3, 1 },
                    { 267, new DateTime(2022, 8, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5769), new DateTime(2024, 2, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5770), 3, 3 },
                    { 268, new DateTime(2022, 7, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 9, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5775), 8, 1 },
                    { 269, new DateTime(2022, 2, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5778), new DateTime(2024, 12, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5779), 8, 1 },
                    { 270, new DateTime(2023, 6, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5782), new DateTime(2024, 4, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5783), 7, 1 },
                    { 271, new DateTime(2023, 2, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5786), new DateTime(2022, 10, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5787), 8, 2 },
                    { 272, new DateTime(2022, 10, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5791), new DateTime(2022, 6, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5792), 9, 2 },
                    { 273, new DateTime(2022, 11, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5795), new DateTime(2025, 3, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5796), 9, 1 },
                    { 274, new DateTime(2023, 3, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5799), new DateTime(2024, 6, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5800), 8, 1 },
                    { 275, new DateTime(2022, 6, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5805), new DateTime(2024, 5, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5807), 7, 1 },
                    { 276, new DateTime(2022, 12, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5809), new DateTime(2024, 6, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5811), 6, 1 },
                    { 277, new DateTime(2023, 2, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5813), new DateTime(2024, 5, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5814), 8, 1 },
                    { 278, new DateTime(2022, 8, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5817), new DateTime(2024, 9, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5818), 5, 1 },
                    { 279, new DateTime(2022, 5, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5821), new DateTime(2025, 3, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5823), 4, 1 },
                    { 280, new DateTime(2022, 11, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5826), new DateTime(2025, 6, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5827), 8, 1 },
                    { 281, new DateTime(2022, 12, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 7, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5831), 7, 1 },
                    { 282, new DateTime(2022, 11, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5834), new DateTime(2024, 8, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5835), 9, 1 },
                    { 283, new DateTime(2023, 2, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5838), new DateTime(2022, 7, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5839), 6, 2 },
                    { 284, new DateTime(2022, 3, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5842), new DateTime(2025, 1, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5843), 7, 1 },
                    { 285, new DateTime(2022, 10, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5846), new DateTime(2025, 1, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5848), 8, 1 },
                    { 286, new DateTime(2023, 5, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5851), new DateTime(2022, 7, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5852), 2, 2 },
                    { 287, new DateTime(2023, 7, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5855), new DateTime(2024, 8, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5856), 6, 1 },
                    { 288, new DateTime(2022, 10, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5859), new DateTime(2024, 6, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5861), 1, 1 },
                    { 289, new DateTime(2022, 9, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5864), new DateTime(2025, 5, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5865), 6, 1 },
                    { 290, new DateTime(2022, 6, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5868), new DateTime(2024, 9, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5869), 9, 1 },
                    { 291, new DateTime(2022, 12, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5872), new DateTime(2025, 2, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5874), 6, 1 },
                    { 292, new DateTime(2022, 11, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5877), new DateTime(2022, 11, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5878), 3, 2 },
                    { 293, new DateTime(2022, 8, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5881), new DateTime(2024, 9, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5883), 5, 1 },
                    { 294, new DateTime(2022, 11, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5886), new DateTime(2024, 12, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5887), 8, 1 },
                    { 295, new DateTime(2022, 5, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 5, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5891), 2, 1 },
                    { 296, new DateTime(2023, 2, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5895), new DateTime(2024, 11, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5896), 1, 1 },
                    { 297, new DateTime(2023, 7, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5899), new DateTime(2024, 6, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5900), 8, 1 },
                    { 298, new DateTime(2022, 5, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5903), new DateTime(2024, 3, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5904), 7, 1 },
                    { 299, new DateTime(2022, 9, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5908), new DateTime(2025, 8, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5909), 6, 3 },
                    { 300, new DateTime(2023, 1, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 6, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5914), 2, 2 },
                    { 301, new DateTime(2023, 3, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 1, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5918), 5, 1 },
                    { 302, new DateTime(2022, 10, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5921), new DateTime(2025, 3, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5922), 6, 1 },
                    { 303, new DateTime(2022, 6, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 7, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5926), 6, 1 },
                    { 304, new DateTime(2022, 11, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5929), new DateTime(2025, 2, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5930), 7, 1 },
                    { 305, new DateTime(2023, 2, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5933), new DateTime(2025, 2, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5934), 8, 3 },
                    { 306, new DateTime(2023, 5, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5937), new DateTime(2024, 8, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5939), 1, 1 },
                    { 307, new DateTime(2023, 3, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5942), new DateTime(2024, 11, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5943), 3, 1 },
                    { 308, new DateTime(2022, 8, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5946), new DateTime(2024, 8, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5947), 6, 1 },
                    { 309, new DateTime(2022, 5, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5950), new DateTime(2024, 2, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5951), 2, 1 },
                    { 310, new DateTime(2022, 11, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5954), new DateTime(2024, 10, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5955), 5, 1 },
                    { 311, new DateTime(2022, 5, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5958), new DateTime(2024, 5, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5959), 1, 1 },
                    { 312, new DateTime(2022, 10, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5962), new DateTime(2023, 2, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5963), 5, 2 },
                    { 313, new DateTime(2022, 12, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5966), new DateTime(2025, 6, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5968), 7, 1 },
                    { 314, new DateTime(2022, 11, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5970), new DateTime(2025, 1, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5972), 7, 1 },
                    { 315, new DateTime(2022, 4, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5975), new DateTime(2024, 10, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5976), 9, 1 },
                    { 316, new DateTime(2022, 9, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5979), new DateTime(2024, 12, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5980), 8, 1 },
                    { 317, new DateTime(2023, 5, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5983), new DateTime(2025, 2, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5984), 1, 1 },
                    { 318, new DateTime(2023, 1, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5987), new DateTime(2023, 1, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5989), 7, 2 },
                    { 319, new DateTime(2022, 11, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5992), new DateTime(2024, 9, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5994), 5, 1 },
                    { 320, new DateTime(2022, 6, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5997), new DateTime(2024, 6, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(5998), 6, 1 },
                    { 321, new DateTime(2022, 9, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6001), new DateTime(2025, 7, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6002), 6, 1 },
                    { 322, new DateTime(2022, 11, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6005), new DateTime(2024, 11, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6006), 2, 1 },
                    { 323, new DateTime(2023, 4, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6009), new DateTime(2022, 11, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6011), 7, 2 },
                    { 324, new DateTime(2023, 5, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6014), new DateTime(2024, 6, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6015), 7, 1 },
                    { 325, new DateTime(2022, 7, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6018), new DateTime(2024, 3, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6019), 8, 1 },
                    { 326, new DateTime(2022, 10, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 2, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6023), 2, 2 },
                    { 327, new DateTime(2022, 5, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6026), new DateTime(2023, 7, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6028), 7, 2 },
                    { 328, new DateTime(2022, 11, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6031), new DateTime(2024, 12, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6032), 6, 1 },
                    { 329, new DateTime(2022, 3, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6086), new DateTime(2025, 5, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6088), 3, 1 },
                    { 330, new DateTime(2022, 12, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6091), new DateTime(2024, 6, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6092), 4, 3 },
                    { 331, new DateTime(2023, 1, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6095), new DateTime(2025, 2, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6096), 8, 3 },
                    { 332, new DateTime(2022, 8, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6099), new DateTime(2025, 4, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6100), 9, 1 },
                    { 333, new DateTime(2022, 4, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6103), new DateTime(2024, 4, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6104), 6, 1 },
                    { 334, new DateTime(2021, 12, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6108), new DateTime(2024, 4, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6109), 6, 1 },
                    { 335, new DateTime(2023, 2, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6112), new DateTime(2025, 2, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6113), 7, 3 },
                    { 336, new DateTime(2023, 6, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6116), new DateTime(2024, 5, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6117), 1, 1 },
                    { 337, new DateTime(2022, 12, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6120), new DateTime(2025, 1, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6122), 5, 3 },
                    { 338, new DateTime(2022, 8, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6125), new DateTime(2024, 3, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6127), 8, 1 },
                    { 339, new DateTime(2022, 10, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6129), new DateTime(2022, 11, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6131), 6, 2 },
                    { 340, new DateTime(2022, 1, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6133), new DateTime(2024, 1, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6135), 6, 1 },
                    { 341, new DateTime(2022, 5, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6137), new DateTime(2024, 3, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6139), 4, 1 },
                    { 342, new DateTime(2023, 2, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6142), new DateTime(2025, 1, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6143), 2, 1 },
                    { 343, new DateTime(2022, 8, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6146), new DateTime(2025, 1, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6147), 3, 1 },
                    { 344, new DateTime(2023, 8, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6150), new DateTime(2024, 9, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6151), 4, 1 },
                    { 345, new DateTime(2022, 5, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6154), new DateTime(2024, 9, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6156), 9, 1 },
                    { 346, new DateTime(2022, 10, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6158), new DateTime(2025, 1, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6160), 2, 1 },
                    { 347, new DateTime(2022, 10, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6163), new DateTime(2024, 2, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6164), 5, 1 },
                    { 348, new DateTime(2022, 12, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6168), new DateTime(2024, 6, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6169), 2, 1 },
                    { 349, new DateTime(2022, 7, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6172), new DateTime(2023, 6, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6173), 9, 2 },
                    { 350, new DateTime(2022, 12, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 2, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6178), 5, 1 },
                    { 351, new DateTime(2022, 11, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6181), new DateTime(2022, 8, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6183), 6, 2 },
                    { 352, new DateTime(2022, 5, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6185), new DateTime(2022, 7, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6187), 2, 2 },
                    { 353, new DateTime(2023, 3, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6190), new DateTime(2025, 5, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6191), 7, 1 },
                    { 354, new DateTime(2022, 9, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6194), new DateTime(2023, 3, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6195), 2, 2 },
                    { 355, new DateTime(2022, 7, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 11, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6200), 6, 3 },
                    { 356, new DateTime(2022, 10, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6203), new DateTime(2024, 12, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6204), 4, 1 },
                    { 357, new DateTime(2022, 1, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6207), new DateTime(2024, 8, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6208), 8, 3 },
                    { 358, new DateTime(2023, 2, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 11, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6213), 6, 1 },
                    { 359, new DateTime(2022, 6, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 8, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6217), 8, 1 },
                    { 360, new DateTime(2023, 2, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6219), new DateTime(2023, 11, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6221), 7, 1 },
                    { 361, new DateTime(2022, 6, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 3, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6225), 6, 1 },
                    { 362, new DateTime(2023, 6, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6228), new DateTime(2024, 9, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6229), 2, 3 },
                    { 363, new DateTime(2023, 2, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6232), new DateTime(2025, 4, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6233), 7, 1 },
                    { 364, new DateTime(2022, 11, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6236), new DateTime(2024, 12, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6238), 2, 1 },
                    { 365, new DateTime(2023, 4, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 10, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6242), 4, 1 },
                    { 366, new DateTime(2022, 9, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6245), new DateTime(2024, 10, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6247), 1, 1 },
                    { 367, new DateTime(2022, 10, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6249), new DateTime(2024, 6, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6251), 7, 1 },
                    { 368, new DateTime(2022, 3, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6254), new DateTime(2024, 3, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6255), 7, 1 },
                    { 369, new DateTime(2022, 12, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6258), new DateTime(2024, 8, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6260), 4, 1 },
                    { 370, new DateTime(2022, 6, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6263), new DateTime(2024, 1, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6264), 4, 1 },
                    { 371, new DateTime(2023, 3, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 12, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6268), 2, 1 },
                    { 372, new DateTime(2022, 2, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6271), new DateTime(2025, 3, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6272), 5, 1 },
                    { 373, new DateTime(2023, 7, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6275), new DateTime(2025, 4, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6276), 5, 1 },
                    { 374, new DateTime(2022, 9, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 7, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6281), 1, 3 },
                    { 375, new DateTime(2022, 12, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6284), new DateTime(2024, 6, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6285), 3, 1 },
                    { 376, new DateTime(2023, 8, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6288), new DateTime(2024, 10, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6290), 7, 1 },
                    { 377, new DateTime(2022, 9, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6293), new DateTime(2025, 4, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6294), 6, 1 },
                    { 378, new DateTime(2022, 7, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6297), new DateTime(2025, 5, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6298), 4, 1 },
                    { 379, new DateTime(2023, 3, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6301), new DateTime(2024, 7, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6303), 1, 1 },
                    { 380, new DateTime(2022, 12, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6306), new DateTime(2024, 1, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6307), 6, 1 },
                    { 381, new DateTime(2022, 11, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6310), new DateTime(2024, 8, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6311), 3, 1 },
                    { 382, new DateTime(2022, 6, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6314), new DateTime(2024, 7, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6316), 1, 1 },
                    { 383, new DateTime(2022, 9, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6319), new DateTime(2024, 8, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6320), 6, 1 },
                    { 384, new DateTime(2022, 8, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6323), new DateTime(2024, 2, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6324), 5, 1 },
                    { 385, new DateTime(2022, 4, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 12, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6328), 9, 1 },
                    { 386, new DateTime(2023, 6, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6331), new DateTime(2024, 3, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6333), 4, 1 },
                    { 387, new DateTime(2022, 4, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6336), new DateTime(2024, 10, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6337), 9, 1 },
                    { 388, new DateTime(2022, 7, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6340), new DateTime(2024, 7, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6342), 3, 1 },
                    { 389, new DateTime(2022, 4, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6345), new DateTime(2025, 4, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6346), 4, 3 },
                    { 390, new DateTime(2022, 10, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6349), new DateTime(2024, 8, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6351), 6, 1 },
                    { 391, new DateTime(2021, 11, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6353), new DateTime(2024, 8, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6355), 2, 1 },
                    { 392, new DateTime(2023, 2, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6358), new DateTime(2025, 1, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6360), 8, 1 },
                    { 393, new DateTime(2022, 10, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6362), new DateTime(2025, 6, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6364), 2, 1 },
                    { 394, new DateTime(2023, 8, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 6, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6368), 9, 1 },
                    { 395, new DateTime(2023, 3, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6371), new DateTime(2025, 1, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6372), 1, 1 },
                    { 396, new DateTime(2022, 7, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6375), new DateTime(2024, 4, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6376), 4, 3 },
                    { 397, new DateTime(2022, 12, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6379), new DateTime(2022, 10, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6381), 5, 2 },
                    { 398, new DateTime(2022, 2, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6384), new DateTime(2023, 12, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6385), 5, 1 },
                    { 399, new DateTime(2022, 8, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6388), new DateTime(2025, 3, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6389), 6, 1 },
                    { 400, new DateTime(2023, 6, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6392), new DateTime(2024, 1, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6393), 8, 1 },
                    { 401, new DateTime(2022, 11, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6396), new DateTime(2024, 4, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6398), 8, 1 },
                    { 402, new DateTime(2023, 3, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6400), new DateTime(2025, 1, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6402), 1, 1 },
                    { 403, new DateTime(2022, 10, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6404), new DateTime(2024, 5, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6406), 5, 1 },
                    { 404, new DateTime(2022, 8, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6409), new DateTime(2025, 3, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6410), 1, 1 },
                    { 405, new DateTime(2022, 10, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 6, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6414), 1, 1 },
                    { 406, new DateTime(2022, 4, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6417), new DateTime(2024, 7, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6418), 8, 3 },
                    { 407, new DateTime(2022, 4, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 11, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6423), 5, 1 },
                    { 408, new DateTime(2022, 12, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 3, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6427), 9, 3 },
                    { 409, new DateTime(2023, 4, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6430), new DateTime(2025, 4, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6431), 7, 1 },
                    { 410, new DateTime(2022, 10, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6434), new DateTime(2024, 11, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6435), 4, 1 },
                    { 411, new DateTime(2022, 5, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6438), new DateTime(2024, 8, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6439), 3, 1 },
                    { 412, new DateTime(2022, 8, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6442), new DateTime(2025, 7, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6444), 5, 3 },
                    { 413, new DateTime(2023, 6, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6447), new DateTime(2024, 1, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6449), 8, 1 },
                    { 414, new DateTime(2023, 2, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6503), new DateTime(2025, 6, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6504), 9, 1 },
                    { 415, new DateTime(2022, 10, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6507), new DateTime(2024, 6, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6509), 8, 1 },
                    { 416, new DateTime(2022, 1, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6511), new DateTime(2024, 10, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6513), 4, 1 },
                    { 417, new DateTime(2022, 9, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6515), new DateTime(2024, 8, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6517), 2, 1 },
                    { 418, new DateTime(2022, 6, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6520), new DateTime(2024, 4, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6521), 7, 1 },
                    { 419, new DateTime(2022, 11, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 11, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6526), 4, 1 },
                    { 420, new DateTime(2022, 6, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6529), new DateTime(2024, 8, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6530), 6, 1 },
                    { 421, new DateTime(2022, 11, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6533), new DateTime(2024, 5, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6534), 3, 3 },
                    { 422, new DateTime(2023, 1, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6537), new DateTime(2024, 9, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6538), 4, 1 },
                    { 423, new DateTime(2022, 8, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6542), new DateTime(2025, 3, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6543), 6, 1 },
                    { 424, new DateTime(2023, 5, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6546), new DateTime(2024, 9, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6548), 6, 1 },
                    { 425, new DateTime(2023, 2, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 10, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6552), 8, 1 },
                    { 426, new DateTime(2022, 12, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 9, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6556), 4, 1 },
                    { 427, new DateTime(2022, 1, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6560), new DateTime(2024, 2, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6561), 9, 1 },
                    { 428, new DateTime(2022, 8, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6564), new DateTime(2024, 2, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6565), 7, 1 },
                    { 429, new DateTime(2022, 12, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 8, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6570), 8, 1 },
                    { 430, new DateTime(2023, 1, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6573), new DateTime(2024, 2, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6574), 4, 1 },
                    { 431, new DateTime(2023, 5, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6577), new DateTime(2024, 12, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6578), 7, 1 },
                    { 432, new DateTime(2022, 5, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6581), new DateTime(2024, 12, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6583), 1, 1 },
                    { 433, new DateTime(2021, 11, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6586), new DateTime(2025, 3, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6587), 5, 1 },
                    { 434, new DateTime(2022, 1, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6590), new DateTime(2024, 8, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6591), 5, 1 },
                    { 435, new DateTime(2022, 8, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6595), new DateTime(2024, 10, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6596), 6, 1 },
                    { 436, new DateTime(2022, 10, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6599), new DateTime(2025, 1, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6601), 2, 1 },
                    { 437, new DateTime(2022, 8, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6604), new DateTime(2024, 5, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6605), 5, 1 },
                    { 438, new DateTime(2022, 4, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6608), new DateTime(2023, 12, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6609), 3, 3 },
                    { 439, new DateTime(2022, 6, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6613), new DateTime(2024, 1, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6614), 4, 1 },
                    { 440, new DateTime(2022, 3, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6617), new DateTime(2024, 4, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6618), 2, 1 },
                    { 441, new DateTime(2022, 5, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6621), new DateTime(2024, 9, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6622), 4, 1 },
                    { 442, new DateTime(2022, 5, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6625), new DateTime(2024, 2, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6626), 8, 1 },
                    { 443, new DateTime(2022, 9, 5, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6629), new DateTime(2024, 3, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6630), 6, 1 },
                    { 444, new DateTime(2023, 3, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6633), new DateTime(2024, 11, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6635), 4, 3 },
                    { 445, new DateTime(2023, 5, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6638), new DateTime(2024, 2, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6639), 7, 1 },
                    { 446, new DateTime(2022, 11, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6642), new DateTime(2024, 10, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6643), 2, 1 },
                    { 447, new DateTime(2023, 1, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6647), new DateTime(2024, 11, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6648), 1, 1 },
                    { 448, new DateTime(2023, 5, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6651), new DateTime(2025, 1, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6653), 1, 1 },
                    { 449, new DateTime(2022, 5, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6656), new DateTime(2024, 5, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6657), 8, 1 },
                    { 450, new DateTime(2022, 11, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 5, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6662), 5, 1 },
                    { 451, new DateTime(2022, 8, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6665), new DateTime(2022, 3, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6666), 4, 2 },
                    { 452, new DateTime(2022, 9, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6669), new DateTime(2025, 1, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6670), 3, 1 },
                    { 453, new DateTime(2022, 7, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6673), new DateTime(2024, 6, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6674), 6, 1 },
                    { 454, new DateTime(2023, 6, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6677), new DateTime(2025, 1, 29, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6679), 4, 1 },
                    { 455, new DateTime(2022, 10, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6682), new DateTime(2024, 12, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6684), 2, 3 },
                    { 456, new DateTime(2022, 5, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6687), new DateTime(2024, 8, 8, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6688), 7, 1 },
                    { 457, new DateTime(2022, 6, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6691), new DateTime(2024, 4, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6692), 6, 1 },
                    { 458, new DateTime(2023, 1, 2, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 9, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6697), 6, 1 },
                    { 459, new DateTime(2022, 8, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6699), new DateTime(2024, 2, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6701), 1, 1 },
                    { 460, new DateTime(2022, 3, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6704), new DateTime(2024, 12, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6705), 9, 1 },
                    { 461, new DateTime(2022, 9, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6708), new DateTime(2024, 12, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6709), 7, 1 },
                    { 462, new DateTime(2022, 11, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6712), new DateTime(2025, 5, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6713), 7, 1 },
                    { 463, new DateTime(2022, 12, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6716), new DateTime(2024, 8, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6717), 5, 1 },
                    { 464, new DateTime(2022, 5, 31, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6720), new DateTime(2022, 11, 17, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6722), 4, 2 },
                    { 465, new DateTime(2022, 6, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6725), new DateTime(2024, 1, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6726), 4, 1 },
                    { 466, new DateTime(2023, 7, 26, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6729), new DateTime(2025, 3, 6, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6731), 7, 1 },
                    { 467, new DateTime(2022, 7, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6734), new DateTime(2024, 11, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6735), 3, 1 },
                    { 468, new DateTime(2023, 4, 27, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6738), new DateTime(2025, 1, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6739), 9, 1 },
                    { 469, new DateTime(2022, 12, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6742), new DateTime(2023, 12, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6743), 5, 1 },
                    { 470, new DateTime(2022, 1, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6746), new DateTime(2025, 1, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6748), 9, 1 },
                    { 471, new DateTime(2022, 7, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 2, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6752), 7, 1 },
                    { 472, new DateTime(2022, 2, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6755), new DateTime(2024, 10, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6756), 7, 1 },
                    { 473, new DateTime(2022, 6, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6759), new DateTime(2024, 7, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6761), 7, 1 },
                    { 474, new DateTime(2023, 3, 12, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6764), new DateTime(2025, 4, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6765), 2, 1 },
                    { 475, new DateTime(2022, 7, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6768), new DateTime(2024, 11, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6770), 6, 1 },
                    { 476, new DateTime(2023, 1, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6773), new DateTime(2024, 12, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6774), 1, 1 },
                    { 477, new DateTime(2022, 6, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6777), new DateTime(2025, 1, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6778), 5, 3 },
                    { 478, new DateTime(2022, 10, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6781), new DateTime(2024, 1, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6783), 6, 1 },
                    { 479, new DateTime(2022, 10, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 2, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6787), 4, 1 },
                    { 480, new DateTime(2023, 6, 7, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 5, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6791), 5, 1 },
                    { 481, new DateTime(2022, 5, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6794), new DateTime(2024, 6, 14, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6795), 8, 1 },
                    { 482, new DateTime(2022, 8, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6798), new DateTime(2025, 2, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6799), 7, 1 },
                    { 483, new DateTime(2023, 1, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6802), new DateTime(2024, 6, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6804), 2, 1 },
                    { 484, new DateTime(2022, 4, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6807), new DateTime(2025, 5, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6808), 9, 1 },
                    { 485, new DateTime(2023, 2, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6811), new DateTime(2024, 9, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6812), 6, 1 },
                    { 486, new DateTime(2022, 11, 23, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6815), new DateTime(2025, 1, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6817), 3, 3 },
                    { 487, new DateTime(2022, 7, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6820), new DateTime(2025, 7, 24, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6821), 2, 1 },
                    { 488, new DateTime(2023, 3, 30, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 11, 10, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6825), 3, 1 },
                    { 489, new DateTime(2023, 1, 11, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6828), new DateTime(2024, 11, 13, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6830), 6, 1 },
                    { 490, new DateTime(2023, 1, 22, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6833), new DateTime(2024, 5, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6834), 6, 1 },
                    { 491, new DateTime(2023, 3, 1, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 9, 28, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6838), 8, 1 },
                    { 492, new DateTime(2022, 6, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6841), new DateTime(2024, 9, 19, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6843), 3, 1 },
                    { 493, new DateTime(2023, 4, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 10, 21, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6847), 3, 1 },
                    { 494, new DateTime(2023, 3, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6849), new DateTime(2025, 2, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6851), 7, 1 },
                    { 495, new DateTime(2022, 10, 3, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6854), new DateTime(2024, 5, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6855), 3, 1 },
                    { 496, new DateTime(2022, 11, 4, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6858), new DateTime(2025, 4, 25, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6859), 6, 3 },
                    { 497, new DateTime(2022, 11, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6863), new DateTime(2023, 10, 9, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6864), 9, 1 },
                    { 498, new DateTime(2022, 10, 15, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6867), new DateTime(2024, 10, 16, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6868), 2, 1 },
                    { 499, new DateTime(2022, 12, 18, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6924), new DateTime(2024, 7, 20, 7, 10, 1, 310, DateTimeKind.Local).AddTicks(6926), 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "sale",
                columns: new[] { "idPk", "employeeId", "personId", "saledate" },
                values: new object[,]
                {
                    { 1, 2, 7, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 5, new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 9, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 8, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, 9, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 9, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, 7, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 3, 9, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, 9, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 3, 7, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 9, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, 6, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, 8, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, 8, new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 3, 8, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 3, 6, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, 10, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 2, 10, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 3, 6, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 2, 10, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 3, 9, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, 7, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 2, 8, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 3, 5, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 2, 5, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 3, 8, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 3, 6, new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 1, 8, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 1, 9, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 3, 9, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 3, 5, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 3, 7, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 3, 9, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 3, 9, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 3, 6, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 2, 8, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 3, 10, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 2, 6, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 1, 5, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 2, 8, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 1, 8, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 3, 7, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 2, 6, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 1, 9, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 1, 6, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 3, 5, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 1, 8, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 3, 6, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 3, 7, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 3, 9, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 2, 6, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 2, 8, new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 3, 8, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 3, 5, new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 1, 7, new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 2, 8, new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 2, 6, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 1, 6, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 3, 5, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 2, 7, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 2, 9, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 1, 10, new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 3, 5, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 1, 7, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 3, 9, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 2, 5, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 3, 10, new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 2, 7, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 3, 10, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 1, 5, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 1, 8, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 2, 10, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 3, 8, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 2, 7, new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 1, 6, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 2, 5, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 2, 10, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 2, 5, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 1, 8, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 2, 5, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 2, 6, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 3, 7, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 2, 7, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 1, 8, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 1, 7, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 1, 7, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 1, 8, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 3, 10, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 3, 8, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 1, 5, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 2, 7, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 2, 5, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 1, 7, new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 2, 7, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 2, 7, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 1, 6, new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 3, 10, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 3, 8, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 3, 9, new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 3, 7, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, 2, 9, new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 2, 10, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, 2, 8, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, 1, 5, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, 2, 6, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, 1, 8, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, 2, 6, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, 1, 7, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, 2, 6, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, 3, 6, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, 1, 6, new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, 1, 5, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, 1, 7, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, 1, 5, new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, 2, 5, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, 2, 8, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, 3, 6, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, 3, 7, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, 1, 5, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, 2, 9, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, 3, 9, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, 1, 5, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, 3, 6, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, 1, 5, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, 2, 7, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, 1, 10, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, 1, 6, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, 2, 5, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, 3, 10, new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, 2, 9, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "shopping",
                columns: new[] { "idPk", "employeeId", "shoppingDate", "supplierId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 2, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 3, new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, 1, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, 1, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, 2, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, 1, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, 3, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, 3, new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, 2, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, 2, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, 3, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, 2, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, 1, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 19, 1, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, 2, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 21, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 22, 2, new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, 2, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 24, 1, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 26, 1, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, 3, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, 2, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 29, 3, new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, 2, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, 2, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 32, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, 2, new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 34, 1, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 35, 2, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 37, 1, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 38, 2, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 39, 3, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, 2, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, 2, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, 1, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 43, 2, new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 44, 1, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, 3, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 46, 3, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 47, 2, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 48, 3, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, 1, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 50, 1, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 51, 2, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 52, 3, new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 53, 1, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 54, 3, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 55, 1, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 56, 2, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 57, 3, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 58, 2, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 59, 3, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 60, 3, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 61, 1, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 62, 1, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 63, 1, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 64, 1, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 65, 2, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 66, 1, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 67, 1, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 68, 3, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 69, 3, new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 70, 1, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 71, 3, new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 72, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 73, 2, new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 74, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 75, 1, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 76, 3, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 77, 3, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 78, 2, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 79, 2, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 80, 2, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 81, 1, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 82, 3, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 83, 2, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 84, 2, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 85, 1, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 86, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 87, 3, new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 88, 1, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 89, 1, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 90, 1, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 91, 3, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 92, 1, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 93, 2, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 94, 3, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 95, 2, new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 96, 3, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 97, 3, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 98, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 99, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 100, 2, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 101, 2, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 102, 2, new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 103, 1, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 104, 2, new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 105, 2, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 106, 2, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 107, 1, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 108, 3, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 109, 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 110, 2, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 111, 2, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 112, 3, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 113, 2, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 114, 2, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 115, 1, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 116, 2, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 117, 2, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 118, 1, new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 119, 2, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 120, 2, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 121, 3, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 122, 2, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 123, 1, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 124, 2, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 125, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 126, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 127, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 128, 2, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 129, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 130, 3, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "saleDetail",
                columns: new[] { "MedicineId", "SaleId" },
                values: new object[,]
                {
                    { 1, 14 },
                    { 2, 33 },
                    { 3, 27 },
                    { 4, 32 },
                    { 5, 7 },
                    { 6, 62 },
                    { 7, 27 },
                    { 8, 95 },
                    { 9, 108 },
                    { 10, 80 },
                    { 11, 85 },
                    { 12, 27 },
                    { 13, 27 },
                    { 14, 87 },
                    { 15, 89 },
                    { 16, 71 },
                    { 17, 80 },
                    { 18, 109 },
                    { 19, 127 },
                    { 20, 87 },
                    { 21, 96 },
                    { 22, 97 },
                    { 23, 23 },
                    { 24, 121 },
                    { 25, 3 },
                    { 26, 75 },
                    { 27, 44 },
                    { 28, 80 },
                    { 29, 20 },
                    { 30, 1 },
                    { 31, 110 },
                    { 32, 7 },
                    { 33, 84 },
                    { 34, 5 },
                    { 35, 20 },
                    { 36, 25 },
                    { 37, 121 },
                    { 38, 105 },
                    { 39, 19 },
                    { 40, 54 },
                    { 41, 117 },
                    { 42, 29 },
                    { 43, 85 },
                    { 44, 108 },
                    { 45, 25 },
                    { 46, 98 },
                    { 47, 97 },
                    { 48, 38 },
                    { 49, 116 },
                    { 50, 78 },
                    { 51, 20 },
                    { 52, 124 },
                    { 53, 75 },
                    { 54, 123 },
                    { 55, 91 },
                    { 56, 9 },
                    { 57, 78 },
                    { 58, 13 },
                    { 59, 56 },
                    { 60, 103 },
                    { 61, 41 },
                    { 62, 105 },
                    { 63, 123 },
                    { 64, 33 },
                    { 65, 49 },
                    { 66, 74 },
                    { 67, 46 },
                    { 68, 98 },
                    { 69, 90 },
                    { 70, 21 },
                    { 71, 92 },
                    { 72, 58 },
                    { 73, 59 },
                    { 74, 71 },
                    { 75, 116 },
                    { 76, 73 },
                    { 77, 72 },
                    { 78, 118 },
                    { 79, 112 },
                    { 80, 11 },
                    { 81, 107 },
                    { 82, 18 },
                    { 83, 108 },
                    { 84, 127 },
                    { 85, 11 },
                    { 86, 83 },
                    { 87, 4 },
                    { 88, 82 },
                    { 89, 74 },
                    { 90, 22 },
                    { 91, 121 },
                    { 92, 87 },
                    { 93, 125 },
                    { 94, 45 },
                    { 95, 63 },
                    { 96, 52 },
                    { 97, 18 },
                    { 98, 14 },
                    { 99, 105 },
                    { 100, 50 },
                    { 101, 127 }
                });

            migrationBuilder.InsertData(
                table: "shoppingDetail",
                columns: new[] { "MedicineId", "ShoppingId" },
                values: new object[,]
                {
                    { 1, 102 },
                    { 2, 17 },
                    { 3, 76 },
                    { 4, 53 },
                    { 5, 121 },
                    { 6, 33 },
                    { 7, 79 },
                    { 8, 45 },
                    { 9, 103 },
                    { 10, 84 },
                    { 11, 113 },
                    { 12, 75 },
                    { 13, 46 },
                    { 14, 127 },
                    { 15, 6 },
                    { 16, 73 },
                    { 17, 89 },
                    { 18, 53 },
                    { 19, 106 },
                    { 20, 39 },
                    { 21, 33 },
                    { 22, 49 },
                    { 23, 72 },
                    { 24, 113 },
                    { 25, 97 },
                    { 26, 71 },
                    { 27, 112 },
                    { 28, 127 },
                    { 29, 89 },
                    { 30, 61 },
                    { 31, 31 },
                    { 32, 123 },
                    { 33, 38 },
                    { 34, 74 },
                    { 35, 46 },
                    { 36, 51 },
                    { 37, 57 },
                    { 38, 33 },
                    { 39, 8 },
                    { 40, 63 },
                    { 41, 4 },
                    { 42, 70 },
                    { 43, 105 },
                    { 44, 65 },
                    { 45, 73 },
                    { 46, 101 },
                    { 47, 27 },
                    { 48, 100 },
                    { 49, 114 },
                    { 50, 104 },
                    { 51, 64 },
                    { 52, 90 },
                    { 53, 87 },
                    { 54, 67 },
                    { 55, 100 },
                    { 56, 86 },
                    { 57, 114 },
                    { 58, 32 },
                    { 59, 62 },
                    { 60, 35 },
                    { 61, 26 },
                    { 62, 102 },
                    { 63, 15 },
                    { 64, 85 },
                    { 65, 103 },
                    { 66, 76 },
                    { 67, 121 },
                    { 68, 117 },
                    { 69, 29 },
                    { 70, 68 },
                    { 71, 97 },
                    { 72, 68 },
                    { 73, 35 },
                    { 74, 28 },
                    { 75, 122 },
                    { 76, 34 },
                    { 77, 96 },
                    { 78, 9 },
                    { 79, 113 },
                    { 80, 105 },
                    { 81, 21 },
                    { 82, 61 },
                    { 83, 50 },
                    { 84, 107 },
                    { 85, 33 },
                    { 86, 74 },
                    { 87, 123 },
                    { 88, 8 },
                    { 89, 101 },
                    { 90, 43 },
                    { 91, 39 },
                    { 92, 114 },
                    { 93, 3 },
                    { 94, 119 },
                    { 95, 75 },
                    { 96, 125 },
                    { 97, 97 },
                    { 98, 96 },
                    { 99, 30 },
                    { 100, 72 },
                    { 101, 103 },
                    { 102, 20 },
                    { 103, 118 },
                    { 104, 1 },
                    { 105, 33 },
                    { 106, 101 },
                    { 107, 105 },
                    { 108, 126 },
                    { 109, 9 },
                    { 110, 15 },
                    { 111, 45 },
                    { 112, 40 },
                    { 113, 13 },
                    { 114, 66 },
                    { 115, 11 },
                    { 116, 27 },
                    { 117, 101 },
                    { 118, 20 },
                    { 119, 119 },
                    { 120, 3 },
                    { 121, 44 },
                    { 122, 109 },
                    { 123, 76 },
                    { 124, 8 },
                    { 125, 38 },
                    { 126, 63 },
                    { 127, 120 },
                    { 128, 109 },
                    { 129, 14 },
                    { 130, 13 },
                    { 131, 4 },
                    { 132, 123 },
                    { 133, 64 },
                    { 134, 56 },
                    { 135, 125 },
                    { 136, 92 },
                    { 137, 7 },
                    { 138, 13 },
                    { 139, 45 },
                    { 140, 4 },
                    { 141, 129 },
                    { 142, 32 },
                    { 143, 38 },
                    { 144, 85 },
                    { 145, 63 },
                    { 146, 43 },
                    { 147, 87 },
                    { 148, 90 },
                    { 149, 64 },
                    { 150, 15 },
                    { 151, 124 },
                    { 152, 110 },
                    { 153, 39 },
                    { 154, 71 },
                    { 155, 72 },
                    { 156, 100 },
                    { 157, 69 },
                    { 158, 74 },
                    { 159, 56 },
                    { 160, 28 },
                    { 161, 23 },
                    { 162, 34 },
                    { 163, 125 },
                    { 164, 23 },
                    { 165, 2 },
                    { 166, 17 },
                    { 167, 9 },
                    { 168, 13 },
                    { 169, 30 },
                    { 170, 110 },
                    { 171, 78 },
                    { 172, 116 },
                    { 173, 33 },
                    { 174, 7 },
                    { 175, 71 },
                    { 176, 89 },
                    { 177, 37 },
                    { 178, 92 },
                    { 179, 28 },
                    { 180, 54 },
                    { 181, 71 },
                    { 182, 39 },
                    { 183, 65 },
                    { 184, 50 },
                    { 185, 124 },
                    { 186, 119 },
                    { 187, 120 },
                    { 188, 20 },
                    { 189, 94 },
                    { 190, 92 },
                    { 191, 28 },
                    { 192, 11 },
                    { 193, 94 },
                    { 194, 91 },
                    { 195, 1 },
                    { 196, 39 },
                    { 197, 113 },
                    { 198, 7 },
                    { 199, 112 },
                    { 200, 57 },
                    { 201, 121 },
                    { 202, 18 },
                    { 203, 109 },
                    { 204, 2 },
                    { 205, 78 },
                    { 206, 99 },
                    { 207, 10 },
                    { 208, 2 },
                    { 209, 16 },
                    { 210, 29 },
                    { 211, 125 },
                    { 212, 93 },
                    { 213, 102 },
                    { 214, 11 },
                    { 215, 61 },
                    { 216, 11 },
                    { 217, 55 },
                    { 218, 120 },
                    { 219, 5 },
                    { 220, 33 },
                    { 221, 95 },
                    { 222, 114 },
                    { 223, 54 },
                    { 224, 65 },
                    { 225, 68 },
                    { 226, 92 },
                    { 227, 42 },
                    { 228, 82 },
                    { 229, 82 },
                    { 230, 64 },
                    { 231, 18 },
                    { 232, 68 },
                    { 233, 29 },
                    { 234, 30 },
                    { 235, 127 },
                    { 236, 46 },
                    { 237, 112 },
                    { 238, 128 },
                    { 239, 27 },
                    { 240, 48 },
                    { 241, 2 },
                    { 242, 73 },
                    { 243, 43 },
                    { 244, 74 },
                    { 245, 30 },
                    { 246, 80 },
                    { 247, 63 },
                    { 248, 4 },
                    { 249, 34 },
                    { 250, 33 },
                    { 251, 48 },
                    { 252, 41 },
                    { 253, 32 },
                    { 254, 128 },
                    { 255, 28 },
                    { 256, 38 },
                    { 257, 112 },
                    { 258, 11 },
                    { 259, 39 },
                    { 260, 29 },
                    { 261, 103 },
                    { 262, 23 },
                    { 263, 7 },
                    { 264, 90 },
                    { 265, 106 },
                    { 266, 53 },
                    { 267, 55 },
                    { 268, 32 },
                    { 269, 93 },
                    { 270, 9 },
                    { 271, 62 },
                    { 272, 109 },
                    { 273, 110 },
                    { 274, 121 },
                    { 275, 26 },
                    { 276, 23 },
                    { 277, 108 },
                    { 278, 111 },
                    { 279, 103 },
                    { 280, 94 },
                    { 281, 39 },
                    { 282, 73 },
                    { 283, 23 },
                    { 284, 42 },
                    { 285, 124 },
                    { 286, 26 },
                    { 287, 79 },
                    { 288, 43 },
                    { 289, 30 },
                    { 290, 21 },
                    { 291, 109 },
                    { 292, 126 },
                    { 293, 78 },
                    { 294, 8 },
                    { 295, 27 },
                    { 296, 25 },
                    { 297, 111 },
                    { 298, 38 },
                    { 299, 30 },
                    { 300, 31 },
                    { 301, 106 },
                    { 302, 43 },
                    { 303, 109 },
                    { 304, 114 },
                    { 305, 100 },
                    { 306, 122 },
                    { 307, 1 },
                    { 308, 123 },
                    { 309, 114 },
                    { 310, 84 },
                    { 311, 95 },
                    { 312, 121 },
                    { 313, 121 },
                    { 314, 102 },
                    { 315, 40 },
                    { 316, 48 },
                    { 317, 9 },
                    { 318, 72 },
                    { 319, 38 },
                    { 320, 116 },
                    { 321, 56 },
                    { 322, 110 },
                    { 323, 28 },
                    { 324, 98 },
                    { 325, 53 },
                    { 326, 76 },
                    { 327, 14 },
                    { 328, 93 },
                    { 329, 34 },
                    { 330, 11 },
                    { 331, 57 },
                    { 332, 115 },
                    { 333, 108 },
                    { 334, 80 },
                    { 335, 58 },
                    { 336, 9 },
                    { 337, 40 },
                    { 338, 127 },
                    { 339, 38 },
                    { 340, 39 },
                    { 341, 21 },
                    { 342, 91 },
                    { 343, 81 },
                    { 344, 120 },
                    { 345, 112 },
                    { 346, 92 },
                    { 347, 43 },
                    { 348, 82 },
                    { 349, 52 },
                    { 350, 4 },
                    { 351, 122 },
                    { 352, 99 },
                    { 353, 123 },
                    { 354, 123 },
                    { 355, 4 },
                    { 356, 62 },
                    { 357, 35 },
                    { 358, 14 },
                    { 359, 10 },
                    { 360, 17 },
                    { 361, 104 },
                    { 362, 72 },
                    { 363, 84 },
                    { 364, 74 },
                    { 365, 118 },
                    { 366, 16 },
                    { 367, 35 },
                    { 368, 112 },
                    { 369, 89 },
                    { 370, 122 },
                    { 371, 70 },
                    { 372, 6 },
                    { 373, 118 },
                    { 374, 55 },
                    { 375, 80 },
                    { 376, 59 },
                    { 377, 74 },
                    { 378, 118 },
                    { 379, 72 },
                    { 380, 64 },
                    { 381, 61 },
                    { 382, 14 },
                    { 383, 97 },
                    { 384, 85 },
                    { 385, 119 },
                    { 386, 128 },
                    { 387, 29 },
                    { 388, 125 },
                    { 389, 31 },
                    { 390, 42 },
                    { 391, 28 },
                    { 392, 105 },
                    { 393, 76 },
                    { 394, 110 },
                    { 395, 102 },
                    { 396, 63 },
                    { 397, 98 },
                    { 398, 115 },
                    { 399, 40 },
                    { 400, 20 },
                    { 401, 8 },
                    { 402, 101 },
                    { 403, 48 },
                    { 404, 43 },
                    { 405, 78 },
                    { 406, 59 },
                    { 407, 127 },
                    { 408, 118 },
                    { 409, 82 },
                    { 410, 44 },
                    { 411, 123 },
                    { 412, 17 },
                    { 413, 125 },
                    { 414, 112 },
                    { 415, 117 },
                    { 416, 108 },
                    { 417, 19 },
                    { 418, 93 },
                    { 419, 126 },
                    { 420, 89 },
                    { 421, 128 },
                    { 422, 26 },
                    { 423, 68 },
                    { 424, 54 },
                    { 425, 101 },
                    { 426, 64 },
                    { 427, 34 },
                    { 428, 62 },
                    { 429, 122 },
                    { 430, 40 },
                    { 431, 101 },
                    { 432, 23 },
                    { 433, 36 },
                    { 434, 38 },
                    { 435, 20 },
                    { 436, 108 },
                    { 437, 65 },
                    { 438, 40 },
                    { 439, 128 },
                    { 440, 62 },
                    { 441, 84 },
                    { 442, 129 },
                    { 443, 40 },
                    { 444, 120 },
                    { 445, 45 },
                    { 446, 66 },
                    { 447, 5 },
                    { 448, 66 },
                    { 449, 50 },
                    { 450, 109 },
                    { 451, 95 },
                    { 452, 60 },
                    { 453, 117 },
                    { 454, 104 },
                    { 455, 54 },
                    { 456, 75 },
                    { 457, 39 },
                    { 458, 38 },
                    { 459, 117 },
                    { 460, 33 },
                    { 461, 67 },
                    { 462, 17 },
                    { 463, 86 },
                    { 464, 61 },
                    { 465, 25 },
                    { 466, 50 },
                    { 467, 101 },
                    { 468, 61 },
                    { 469, 75 },
                    { 470, 124 },
                    { 471, 75 },
                    { 472, 68 },
                    { 473, 49 },
                    { 474, 30 },
                    { 475, 35 },
                    { 476, 53 },
                    { 477, 15 },
                    { 478, 97 },
                    { 479, 86 },
                    { 480, 104 },
                    { 481, 42 },
                    { 482, 76 },
                    { 483, 55 },
                    { 484, 44 },
                    { 485, 37 },
                    { 486, 18 },
                    { 487, 79 },
                    { 488, 82 },
                    { 489, 115 },
                    { 490, 69 },
                    { 491, 93 },
                    { 492, 49 },
                    { 493, 11 },
                    { 494, 16 },
                    { 495, 106 },
                    { 496, 15 },
                    { 497, 81 },
                    { 498, 103 },
                    { 499, 62 }
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
