using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudHHF.Data.Migrations
{
    public partial class MigrationOrgActualiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DireccionComplejo",
                table: "Organizador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreComplejo",
                table: "Organizador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DireccionComplejo",
                table: "Organizador");

            migrationBuilder.DropColumn(
                name: "NombreComplejo",
                table: "Organizador");
        }
    }
}
