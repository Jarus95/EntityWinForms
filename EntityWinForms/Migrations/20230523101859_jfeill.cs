using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityWinForms.Migrations
{
    public partial class jfeill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "users",
                table: "Users",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "users");
        }
    }
}
