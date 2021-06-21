using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebsite.Migrations
{
    public partial class addedkmDriventocar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KilometersDriven",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 12, 49, 7, 959, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 12, 49, 7, 961, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 12, 49, 7, 961, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 12, 49, 7, 961, DateTimeKind.Local).AddTicks(4831));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KilometersDriven",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 12, 41, 15, 484, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 12, 41, 15, 488, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 12, 41, 15, 488, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 12, 41, 15, 488, DateTimeKind.Local).AddTicks(488));
        }
    }
}
