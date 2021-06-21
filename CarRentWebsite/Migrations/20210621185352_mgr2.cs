using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebsite.Migrations
{
    public partial class mgr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Location_LocationId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Cities_CityId",
                table: "Location");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityId",
                table: "Locations",
                newName: "IX_Locations_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mercedes-Benz" },
                    { 8, "Nissan" },
                    { 7, "Ford" },
                    { 6, "Honda" },
                    { 9, "BMW" },
                    { 4, "Volkswagen" },
                    { 3, "Tesla" },
                    { 2, "Toyota" },
                    { 5, "Porsche" }
                });

            migrationBuilder.InsertData(
                table: "CarClasses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11, "Minivan" },
                    { 18, "Compact SUV" },
                    { 17, "Pickup truck" },
                    { 16, "Mid-size pickup truck" },
                    { 15, "Mini pickup truck" },
                    { 13, "Mid-size SUV" },
                    { 12, "Mini SUV" },
                    { 10, "Compact minivan" },
                    { 14, "Full-size SUV" },
                    { 8, "Hatchback" },
                    { 7, "Mid-size car" },
                    { 6, "Full-size car" },
                    { 5, "Entry-level car" },
                    { 4, "Mid-size car" },
                    { 3, "Compact car" },
                    { 2, "Subcompact car" },
                    { 1, "Microcar" },
                    { 9, "Grand tourer" }
                });

            migrationBuilder.InsertData(
                table: "CarStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Idle" },
                    { 3, "Repair" },
                    { 2, "Rent" }
                });

            migrationBuilder.InsertData(
                table: "CarTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Econom" },
                    { 2, "Business" },
                    { 3, "Luxury" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Kharkiw" },
                    { 4, "Kyiv" },
                    { 2, "Lviv" },
                    { 1, "Dnipro" }
                });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "FuelCapacity", "Name", "Power", "Torque", "WinCode" },
                values: new object[,]
                {
                    { 4, 6, "Engine4", 120, 45, "9034hh5" },
                    { 3, 6, "Engine3", 120, 45, "1123456" },
                    { 2, 6, "Engine2", 120, 45, "ASttrra95" },
                    { 1, 6, "Engine1", 120, 45, "ASD45ufa95" }
                });

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Electric" });

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Propane" },
                    { 2, "Diesel" },
                    { 4, "Hybrid" },
                    { 1, "Petrol" }
                });

            migrationBuilder.InsertData(
                table: "PriceCoefficients",
                columns: new[] { "Id", "CarId", "DaysCount", "Price" },
                values: new object[,]
                {
                    { 6, 2, 7, 70.0 },
                    { 15, 4, 14, 50.0 },
                    { 14, 4, 7, 60.0 },
                    { 13, 4, 4, 70.0 },
                    { 12, 3, 21, 80.0 },
                    { 11, 3, 14, 90.0 },
                    { 10, 3, 7, 120.0 },
                    { 9, 3, 4, 150.0 },
                    { 8, 2, 21, 40.0 },
                    { 7, 2, 14, 60.0 },
                    { 16, 4, 21, 40.0 },
                    { 5, 2, 4, 90.0 },
                    { 4, 1, 21, 70.0 },
                    { 3, 1, 14, 90.0 },
                    { 2, 1, 7, 150.0 },
                    { 1, 1, 4, 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "MT" },
                    { 3, "AM" },
                    { 1, "AT" },
                    { 4, "CVT" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Building", "CityId", "Street" },
                values: new object[,]
                {
                    { 3, "46", 1, "Heroes Avenue" },
                    { 2, "17", 2, "Bandera Street" },
                    { 4, "34", 3, "Antonov Street" },
                    { 1, "7a", 4, "Veresneva Street" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "LocationId", "RegisterDate" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBjOLV4oC85vIevarurD4-EoGNKKyqKVY74w&usqp=CAU", 1, new DateTime(2021, 6, 21, 21, 53, 52, 168, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "LocationId", "RegisterDate" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBjOLV4oC85vIevarurD4-EoGNKKyqKVY74w&usqp=CAU", 4, new DateTime(2021, 6, 21, 21, 53, 52, 170, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "LocationId", "RegisterDate" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBjOLV4oC85vIevarurD4-EoGNKKyqKVY74w&usqp=CAU", 2, new DateTime(2021, 6, 21, 21, 53, 52, 170, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "LocationId", "RegisterDate" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBjOLV4oC85vIevarurD4-EoGNKKyqKVY74w&usqp=CAU", 4, new DateTime(2021, 6, 21, 21, 53, 52, 170, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Locations_LocationId",
                table: "Cars",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Cities_CityId",
                table: "Locations",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Locations_LocationId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Cities_CityId",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PriceCoefficients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_CityId",
                table: "Location",
                newName: "IX_Location_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "LocationId", "RegisterDate" },
                values: new object[] { "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", 0, new DateTime(2021, 6, 21, 12, 49, 7, 959, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "LocationId", "RegisterDate" },
                values: new object[] { "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", 0, new DateTime(2021, 6, 21, 12, 49, 7, 961, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "LocationId", "RegisterDate" },
                values: new object[] { "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", 0, new DateTime(2021, 6, 21, 12, 49, 7, 961, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "LocationId", "RegisterDate" },
                values: new object[] { "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", 0, new DateTime(2021, 6, 21, 12, 49, 7, 961, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Location_LocationId",
                table: "Cars",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Cities_CityId",
                table: "Location",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
