using Microsoft.EntityFrameworkCore.Migrations;

namespace NKAYM.Migrations
{
    public partial class editTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutSick",
                table: "DocRequests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutSick",
                table: "DocRequests",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
