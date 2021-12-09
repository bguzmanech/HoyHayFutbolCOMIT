using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudHHF.Data.Migrations
{
    public partial class MigracionPrueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Partidos",
                table: "Partidos");

            migrationBuilder.RenameTable(
                name: "Partidos",
                newName: "Partido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partido",
                table: "Partido",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Partido",
                table: "Partido");

            migrationBuilder.RenameTable(
                name: "Partido",
                newName: "Partidos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partidos",
                table: "Partidos",
                column: "ID");
        }
    }
}
