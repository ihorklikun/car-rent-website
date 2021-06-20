using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebsite.Migrations
{
    public partial class UpdatedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 17, 13, 18, 39, 216, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 17, 13, 18, 39, 220, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 17, 13, 18, 39, 220, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 17, 13, 18, 39, 220, DateTimeKind.Local).AddTicks(9389));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 17, 11, 43, 19, 461, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 17, 11, 43, 19, 464, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 17, 11, 43, 19, 464, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegisterDate",
                value: new DateTime(2021, 6, 17, 11, 43, 19, 464, DateTimeKind.Local).AddTicks(2321));
        }
    }
}
