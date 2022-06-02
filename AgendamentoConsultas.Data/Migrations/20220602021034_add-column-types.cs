using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendamentoConsultas.Data.Migrations
{
    public partial class addcolumntypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeCliente",
                table: "Consultas",
                type: "varchar(60)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Consultas",
                type: "char(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeCliente",
                table: "Consultas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(60)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Consultas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(11)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
