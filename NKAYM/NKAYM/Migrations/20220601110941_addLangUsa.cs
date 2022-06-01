using Microsoft.EntityFrameworkCore.Migrations;

namespace NKAYM.Migrations
{
    public partial class addLangUsa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LangUsa",
                table: "NavMenus",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LangUsa",
                table: "NavMenus");
        }
    }
}
