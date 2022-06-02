using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendamentoConsultas.Data.Migrations
{
    public partial class changedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Consultas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Consultas",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "Data",
                table: "Consultas",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Hora",
                table: "Consultas",
                type: "time(6)",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }
    }
}
