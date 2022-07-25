using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prpperty_Backend.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    IdOwner = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10001, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Birthday = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.IdOwner);
                });

            migrationBuilder.CreateTable(
                name: "Propertyes",
                columns: table => new
                {
                    IdProperty = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "2001, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false),
                    CodeInternal = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ownerIdOwner = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propertyes", x => x.IdProperty);
                    table.ForeignKey(
                        name: "FK_Propertyes_Owners_ownerIdOwner",
                        column: x => x.ownerIdOwner,
                        principalTable: "Owners",
                        principalColumn: "IdOwner");
                });

            migrationBuilder.CreateTable(
                name: "PropertyImages",
                columns: table => new
                {
                    IdPropertyImage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "3001, 1"),
                    Ruta = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    propertyIdProperty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyImages", x => x.IdPropertyImage);
                    table.ForeignKey(
                        name: "FK_PropertyImages_Propertyes_propertyIdProperty",
                        column: x => x.propertyIdProperty,
                        principalTable: "Propertyes",
                        principalColumn: "IdProperty");
                });

            migrationBuilder.CreateTable(
                name: "PropertyTraces",
                columns: table => new
                {
                    IdPropertyTrace = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "4001, 1"),
                    DateSale = table.Column<DateTime>(type: "date", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Value = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    propertyIdProperty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTraces", x => x.IdPropertyTrace);
                    table.ForeignKey(
                        name: "FK_PropertyTraces_Propertyes_propertyIdProperty",
                        column: x => x.propertyIdProperty,
                        principalTable: "Propertyes",
                        principalColumn: "IdProperty");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Propertyes_ownerIdOwner",
                table: "Propertyes",
                column: "ownerIdOwner");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImages_propertyIdProperty",
                table: "PropertyImages",
                column: "propertyIdProperty");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTraces_propertyIdProperty",
                table: "PropertyTraces",
                column: "propertyIdProperty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyImages");

            migrationBuilder.DropTable(
                name: "PropertyTraces");

            migrationBuilder.DropTable(
                name: "Propertyes");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
