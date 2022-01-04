using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaViajamar.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "atendimento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atendimento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "compras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCompra = table.Column<int>(type: "int", nullable: false),
                    idComprador = table.Column<int>(type: "int", nullable: false),
                    Ida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Volta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compras", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "destinos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    local = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_destinos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comprasid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_clientes_compras_Comprasid",
                        column: x => x.Comprasid,
                        principalTable: "compras",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_Comprasid",
                table: "clientes",
                column: "Comprasid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "atendimento");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "destinos");

            migrationBuilder.DropTable(
                name: "compras");
        }
    }
}
