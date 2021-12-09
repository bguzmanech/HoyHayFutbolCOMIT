using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudHHF.Data.Migrations
{
    public partial class LocalidadComplejo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocalidadComplejo",
                table: "Organizador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalidadComplejo",
                table: "Organizador");
        }
    }
}
