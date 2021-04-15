using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_mvc_web.Migrations
{
    public partial class NewMigragiton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Language",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Language",
                newName: "Text");
        }
    }
}
