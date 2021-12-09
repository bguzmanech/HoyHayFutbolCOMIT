using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudHHF.Data.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Complejo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioTotal = table.Column<int>(type: "int", nullable: false),
                    FechaPartido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoPartido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoTecho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoPiso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RangoEtario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partidos");
        }
    }
}
