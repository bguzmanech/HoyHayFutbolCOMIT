﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudHHF.Data.Migrations
{
    public partial class MigrationOrganizador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizador",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTorneo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioPorEquipo = table.Column<int>(type: "int", nullable: false),
                    FechaDelTorneo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModalidadDePartido = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizador", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organizador");
        }
    }
}
