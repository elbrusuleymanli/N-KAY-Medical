using Microsoft.EntityFrameworkCore.Migrations;

namespace NKAYM.Migrations
{
    public partial class editRequesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "DocRequests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "DocRequests",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
