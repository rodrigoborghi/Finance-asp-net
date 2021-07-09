using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finance.infra.Migrations
{
    public partial class DataVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataVenda",
                table: "AtivosCarteira",
                type: "DATETIME",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataVenda",
                table: "AtivosCarteira",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldNullable: true);
        }
    }
}
