using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstEFCore.Migrations
{
    public partial class CodeFirstAddStandard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentStandard",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentStandard",
                table: "Students");
        }
    }
}
