using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP2_SD.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chaves",
                columns: table => new
                {
                    ChaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numeros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estrelas = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chaves", x => x.ChaveId);
                });

            migrationBuilder.CreateTable(
                name: "Apostas",
                columns: table => new
                {
                    RegistoApostaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIF = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChaveId = table.Column<int>(type: "int", nullable: true),
                    Arquivada = table.Column<bool>(type: "bit", nullable: false),
                    Premio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apostas", x => x.RegistoApostaId);
                    table.ForeignKey(
                        name: "FK_Apostas_Chaves_ChaveId",
                        column: x => x.ChaveId,
                        principalTable: "Chaves",
                        principalColumn: "ChaveId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apostas_ChaveId",
                table: "Apostas",
                column: "ChaveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apostas");

            migrationBuilder.DropTable(
                name: "Chaves");
        }
    }
}
