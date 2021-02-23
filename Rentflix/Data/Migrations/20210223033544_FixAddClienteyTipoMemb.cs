using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentflix.Data.Migrations
{
    public partial class FixAddClienteyTipoMemb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoMembresia",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "INTEGER", nullable: false),
                    CostoRegistro = table.Column<short>(type: "INTEGER", nullable: false),
                    DuracionEnMeses = table.Column<byte>(type: "INTEGER", nullable: false),
                    Descuento = table.Column<byte>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMembresia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    EstaSubscrito = table.Column<bool>(type: "INTEGER", nullable: false),
                    TipoMembresiaId = table.Column<byte>(type: "INTEGER", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_TipoMembresia_TipoMembresiaId",
                        column: x => x.TipoMembresiaId,
                        principalTable: "TipoMembresia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_TipoMembresiaId",
                table: "Cliente",
                column: "TipoMembresiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "TipoMembresia");
        }
    }
}
