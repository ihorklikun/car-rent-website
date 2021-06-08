using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebsite.Data.Migrations
{
    public partial class Addedinfotousers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagerInfo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkerInfo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ManagerInfo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkerInfo",
                table: "AspNetUsers");
        }
    }
}
