using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebsite.Migrations
{
    public partial class mgr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 22, 21, 35, 34, 72, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 22, 21, 35, 34, 78, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 22, 21, 35, 34, 78, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 22, 21, 35, 34, 78, DateTimeKind.Local).AddTicks(1275));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 22, 19, 13, 398, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 22, 19, 13, 400, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 22, 19, 13, 400, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 21, 22, 19, 13, 400, DateTimeKind.Local).AddTicks(5155));
        }
    }
}
