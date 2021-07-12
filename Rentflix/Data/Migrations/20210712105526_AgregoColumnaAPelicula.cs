using Microsoft.EntityFrameworkCore.Migrations;

namespace Rentflix.Data.Migrations
{
    public partial class AgregoColumnaAPelicula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Pelicula",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Pelicula");
        }
    }
}
