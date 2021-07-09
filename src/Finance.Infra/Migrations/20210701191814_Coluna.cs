using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finance.infra.Migrations
{
    public partial class Coluna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtivosCarteira_Ativos_AtivoId",
                table: "AtivosCarteira");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataVenda",
                table: "AtivosCarteira",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "AtivoId",
                table: "AtivosCarteira",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AtivosCarteira_Ativos_AtivoId",
                table: "AtivosCarteira",
                column: "AtivoId",
                principalTable: "Ativos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtivosCarteira_Ativos_AtivoId",
                table: "AtivosCarteira");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataVenda",
                table: "AtivosCarteira",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<int>(
                name: "AtivoId",
                table: "AtivosCarteira",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_AtivosCarteira_Ativos_AtivoId",
                table: "AtivosCarteira",
                column: "AtivoId",
                principalTable: "Ativos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
