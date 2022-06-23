using Microsoft.EntityFrameworkCore.Migrations;

namespace NKAYM.Migrations
{
    public partial class adLangToSrv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Services",
                newName: "Title_RU");

            migrationBuilder.AddColumn<string>(
                name: "Title_AZ",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title_EN",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title_AZ",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Title_EN",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "Title_RU",
                table: "Services",
                newName: "Title");
        }
    }
}
