using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndProject.Migrations
{
    public partial class IsConfirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirm",
                table: "Comments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirm",
                table: "Comments");
        }
    }
}
