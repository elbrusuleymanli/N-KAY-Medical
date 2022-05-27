using Microsoft.EntityFrameworkCore.Migrations;

namespace NKAYM.Migrations
{
    public partial class editRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "DocRequests");

            migrationBuilder.DropColumn(
                name: "PatronomicName",
                table: "DocRequests");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "DocRequests",
                newName: "Fullname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "DocRequests",
                newName: "Surname");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DocRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatronomicName",
                table: "DocRequests",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
