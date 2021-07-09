using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finance.infra.Migrations
{
    public partial class NovaVersao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    Telefone = table.Column<string>(type: "CHAR(11)", nullable: false),
                    CEP = table.Column<string>(type: "CHAR(8)", nullable: false),
                    Estado = table.Column<string>(type: "CHAR(2)", nullable: false),
                    Cidade = table.Column<string>(type: "CHAR(60)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corretoras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corretoras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ativos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IdCategoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ativos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ativos_Categorias_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carteiras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IdCorretora = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carteiras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carteiras_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carteiras_Corretoras_IdCorretora",
                        column: x => x.IdCorretora,
                        principalTable: "Corretoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtivosCarteira",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarteiraId = table.Column<int>(nullable: false),
                    AtivoId = table.Column<int>(nullable: true),
                    Valor = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "INT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    delete = table.Column<string>(type: "CHAR(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtivosCarteira", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtivosCarteira_Ativos_AtivoId",
                        column: x => x.AtivoId,
                        principalTable: "Ativos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtivosCarteira_Carteiras_CarteiraId",
                        column: x => x.CarteiraId,
                        principalTable: "Carteiras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ativos_IdCategoria",
                table: "Ativos",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_AtivosCarteira_AtivoId",
                table: "AtivosCarteira",
                column: "AtivoId");

            migrationBuilder.CreateIndex(
                name: "IX_AtivosCarteira_CarteiraId",
                table: "AtivosCarteira",
                column: "CarteiraId");

            migrationBuilder.CreateIndex(
                name: "IX_Carteiras_IdCliente",
                table: "Carteiras",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Carteiras_IdCorretora",
                table: "Carteiras",
                column: "IdCorretora");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtivosCarteira");

            migrationBuilder.DropTable(
                name: "Ativos");

            migrationBuilder.DropTable(
                name: "Carteiras");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Corretoras");
        }
    }
}
