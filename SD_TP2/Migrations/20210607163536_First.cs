using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_TP2.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apostas",
                columns: table => new
                {
                    RegistoApostaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIF = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Numeros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estrelas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arquivada = table.Column<bool>(type: "bit", nullable: false),
                    Premio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apostas", x => x.RegistoApostaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apostas");
        }
    }
}
