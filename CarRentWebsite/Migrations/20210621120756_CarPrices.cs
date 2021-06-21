using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebsite.Migrations
{
    public partial class CarPrices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReports_AspNetUsers_ManagerId",
                table: "ConditionReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReports_ConditionMarks_InteriorConditionId",
                table: "ConditionReports");

            migrationBuilder.DropIndex(
                name: "IX_ConditionReports_ManagerId",
                table: "ConditionReports");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

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
                keyValue: 3);

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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Engines",
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
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarClasses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarStatuses",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.RenameColumn(
                name: "Coefficient",
                table: "PriceCoefficients",
                newName: "Price");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "ConditionReports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LpcConditionId",
                table: "ConditionReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ManagerId1",
                table: "ConditionReports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConditionReports_LpcConditionId",
                table: "ConditionReports",
                column: "LpcConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionReports_ManagerId1",
                table: "ConditionReports",
                column: "ManagerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_LocationId",
                table: "Cars",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CityId",
                table: "Location",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Location_LocationId",
                table: "Cars",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReports_AspNetUsers_ManagerId1",
                table: "ConditionReports",
                column: "ManagerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReports_ConditionMarks_InteriorConditionId",
                table: "ConditionReports",
                column: "InteriorConditionId",
                principalTable: "ConditionMarks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReports_ConditionMarks_LpcConditionId",
                table: "ConditionReports",
                column: "LpcConditionId",
                principalTable: "ConditionMarks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Location_LocationId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReports_AspNetUsers_ManagerId1",
                table: "ConditionReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReports_ConditionMarks_InteriorConditionId",
                table: "ConditionReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReports_ConditionMarks_LpcConditionId",
                table: "ConditionReports");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_ConditionReports_LpcConditionId",
                table: "ConditionReports");

            migrationBuilder.DropIndex(
                name: "IX_ConditionReports_ManagerId1",
                table: "ConditionReports");

            migrationBuilder.DropIndex(
                name: "IX_Cars_LocationId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "LpcConditionId",
                table: "ConditionReports");

            migrationBuilder.DropColumn(
                name: "ManagerId1",
                table: "ConditionReports");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "PriceCoefficients",
                newName: "Coefficient");

            migrationBuilder.AlterColumn<string>(
                name: "ManagerId",
                table: "ConditionReports",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                    { 17, "Pickup truck" },
                    { 16, "Mid-size pickup truck" },
                    { 15, "Mini pickup truck" },
                    { 14, "Full-size SUV" },
                    { 13, "Mid-size SUV" },
                    { 12, "Mini SUV" },
                    { 10, "Compact minivan" },
                    { 18, "Compact SUV" },
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
                    { 2, "Rent" },
                    { 3, "Repair" }
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
                    { 4, "Kyiv" },
                    { 3, "Kharkiw" },
                    { 1, "Dnipro" },
                    { 2, "Lviv" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "Poland" },
                    { 3, "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "FuelCapacity", "Name", "Power", "Torque", "WinCode" },
                values: new object[,]
                {
                    { 3, 6, "Engine3", 120, 45, "1123456" },
                    { 4, 6, "Engine4", 120, 45, "9034hh5" }
                });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "FuelCapacity", "Name", "Power", "Torque", "WinCode" },
                values: new object[,]
                {
                    { 1, 6, "Engine1", 120, 45, "ASD45ufa95" },
                    { 2, 6, "Engine2", 120, 45, "ASttrra95" }
                });

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Petrol" },
                    { 2, "Diesel" },
                    { 3, "Electric" },
                    { 4, "Hybrid" },
                    { 5, "Propane" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "AM" },
                    { 1, "AT" },
                    { 2, "MT" },
                    { 4, "CVT" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "CarClassId", "CarStatusId", "CarTypeId", "Description", "EngineId", "FuelId", "ImageUrl", "RegisterDate", "RegisterNumber", "SeatsCount", "TransmissionId", "TrunkSize" },
                values: new object[,]
                {
                    { 1, 1, 2, 1, 1, "Car description...", 2, 1, "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", new DateTime(2021, 6, 17, 13, 18, 39, 216, DateTimeKind.Local).AddTicks(6655), "BO7104RT", 4, 1, 40 },
                    { 2, 3, 4, 1, 2, "Car description2...", 3, 1, "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", new DateTime(2021, 6, 17, 13, 18, 39, 220, DateTimeKind.Local).AddTicks(9323), "AA7104MT", 4, 2, 60 },
                    { 3, 1, 5, 1, 3, "Car description2...", 4, 1, "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", new DateTime(2021, 6, 17, 13, 18, 39, 220, DateTimeKind.Local).AddTicks(9381), "AE5544KE", 4, 3, 80 },
                    { 4, 1, 5, 1, 3, "Car description2...", 4, 1, "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", new DateTime(2021, 6, 17, 13, 18, 39, 220, DateTimeKind.Local).AddTicks(9389), "AE5544KE", 4, 3, 60 }
                });

            migrationBuilder.InsertData(
                table: "PriceCoefficients",
                columns: new[] { "Id", "CarId", "Coefficient", "DaysCount" },
                values: new object[,]
                {
                    { 1, 1, 0.90000000000000002, 4 },
                    { 2, 1, 0.59999999999999998, 7 },
                    { 3, 1, 0.5, 14 },
                    { 4, 1, 0.20000000000000001, 21 },
                    { 5, 2, 0.80000000000000004, 4 },
                    { 6, 2, 0.69999999999999996, 7 },
                    { 7, 2, 0.59999999999999998, 14 },
                    { 8, 2, 0.5, 21 },
                    { 9, 3, 0.80000000000000004, 4 },
                    { 10, 3, 0.69999999999999996, 7 },
                    { 11, 3, 0.59999999999999998, 14 },
                    { 12, 3, 0.5, 21 },
                    { 13, 4, 0.90000000000000002, 4 },
                    { 14, 4, 0.80000000000000004, 7 },
                    { 15, 4, 0.69999999999999996, 14 },
                    { 16, 4, 0.59999999999999998, 21 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConditionReports_ManagerId",
                table: "ConditionReports",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReports_AspNetUsers_ManagerId",
                table: "ConditionReports",
                column: "ManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReports_ConditionMarks_InteriorConditionId",
                table: "ConditionReports",
                column: "InteriorConditionId",
                principalTable: "ConditionMarks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
