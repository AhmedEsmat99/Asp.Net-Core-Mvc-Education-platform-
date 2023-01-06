using Microsoft.EntityFrameworkCore.Migrations;

namespace Education_platform.Migrations
{
    public partial class updateResultTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Result",
                table: "ResultStudents");

            migrationBuilder.AlterColumn<int>(
                name: "Degree",
                table: "ResultStudents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Degree",
                table: "ResultStudents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "ResultStudents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
