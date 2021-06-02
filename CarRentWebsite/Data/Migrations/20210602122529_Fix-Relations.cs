using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace CarRentWebsite.Data.Migrations
{
    public partial class FixRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_CarClass_CarClassId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_CarType_CarTypeId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Engine_EngineId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Fuel_FuelId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Location_LocationId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Status_StatusId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Transmition_TransmitionId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServiceReport_CarService_CarServiceId",
                table: "CarServiceReport");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServiceReport_ConditionReport_ConditionReportId",
                table: "CarServiceReport");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReport_AspNetUsers_UserId1",
                table: "ConditionReport");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReport_Car_CarId",
                table: "ConditionReport");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReport_ConditionMark_InteriorConditionId",
                table: "ConditionReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_City_CityId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Country_CountryId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_AspNetUsers_UserId1",
                table: "Rent");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Car_CarId",
                table: "Rent");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_RentStatus_RentStatusId",
                table: "Rent");

            migrationBuilder.DropForeignKey(
                name: "FK_RentRentAdditionalOption_Rent_RentsId",
                table: "RentRentAdditionalOption");

            migrationBuilder.DropForeignKey(
                name: "FK_RentRentAdditionalOption_RentAdditionalOption_AdditionalOptionsId",
                table: "RentRentAdditionalOption");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_UserId1",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Car_CarId",
                table: "Review");

            migrationBuilder.DropTable(
                name: "PriceCoeficient");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Transmition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_UserId1",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentStatus",
                table: "RentStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentAdditionalOption",
                table: "RentAdditionalOption");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rent",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_UserId1",
                table: "Rent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fuel",
                table: "Fuel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engine",
                table: "Engine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConditionReport",
                table: "ConditionReport");

            migrationBuilder.DropIndex(
                name: "IX_ConditionReport_UserId1",
                table: "ConditionReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConditionMark",
                table: "ConditionMark");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarType",
                table: "CarType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarServiceReport",
                table: "CarServiceReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarService",
                table: "CarService");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarClass",
                table: "CarClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "ConditionReport");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "RentStatus",
                newName: "RentStatuses");

            migrationBuilder.RenameTable(
                name: "RentAdditionalOption",
                newName: "RentAdditionalOptions");

            migrationBuilder.RenameTable(
                name: "Rent",
                newName: "Rents");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "Fuel",
                newName: "Fuels");

            migrationBuilder.RenameTable(
                name: "Engine",
                newName: "Engines");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "ConditionReport",
                newName: "ConditionReports");

            migrationBuilder.RenameTable(
                name: "ConditionMark",
                newName: "ConditionMarks");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "CarType",
                newName: "CarTypes");

            migrationBuilder.RenameTable(
                name: "CarServiceReport",
                newName: "CarServiceReports");

            migrationBuilder.RenameTable(
                name: "CarService",
                newName: "CarServices");

            migrationBuilder.RenameTable(
                name: "CarClass",
                newName: "CarClasses");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Cars");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reviews",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_CarId",
                table: "Reviews",
                newName: "IX_Reviews_CarId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Rents",
                newName: "ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Rent_RentStatusId",
                table: "Rents",
                newName: "IX_Rents_RentStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Rent_CarId",
                table: "Rents",
                newName: "IX_Rents_CarId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CountryId",
                table: "Locations",
                newName: "IX_Locations_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_CityId",
                table: "Locations",
                newName: "IX_Locations_CityId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ConditionReports",
                newName: "ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionReport_InteriorConditionId",
                table: "ConditionReports",
                newName: "IX_ConditionReports_InteriorConditionId");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionReport_CarId",
                table: "ConditionReports",
                newName: "IX_ConditionReports_CarId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServiceReport_ConditionReportId",
                table: "CarServiceReports",
                newName: "IX_CarServiceReports_ConditionReportId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServiceReport_CarServiceId",
                table: "CarServiceReports",
                newName: "IX_CarServiceReports_CarServiceId");

            migrationBuilder.RenameColumn(
                name: "TransmitionId",
                table: "Cars",
                newName: "TransmissionId");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Cars",
                newName: "CarStatusId");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "Cars",
                newName: "ImageURL");

            migrationBuilder.RenameIndex(
                name: "IX_Car_TransmitionId",
                table: "Cars",
                newName: "IX_Cars_TransmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_StatusId",
                table: "Cars",
                newName: "IX_Cars_CarStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_LocationId",
                table: "Cars",
                newName: "IX_Cars_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_FuelId",
                table: "Cars",
                newName: "IX_Cars_FuelId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_EngineId",
                table: "Cars",
                newName: "IX_Cars_EngineId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_CarTypeId",
                table: "Cars",
                newName: "IX_Cars_CarTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_CarClassId",
                table: "Cars",
                newName: "IX_Cars_CarClassId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceWorkerId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Rents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Point>(
                name: "Coordinate",
                table: "Locations",
                type: "geography",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceWorkerId",
                table: "CarServiceReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentStatuses",
                table: "RentStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentAdditionalOptions",
                table: "RentAdditionalOptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rents",
                table: "Rents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fuels",
                table: "Fuels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engines",
                table: "Engines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConditionReports",
                table: "ConditionReports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConditionMarks",
                table: "ConditionMarks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarTypes",
                table: "CarTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarServiceReports",
                table: "CarServiceReports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarServices",
                table: "CarServices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarClasses",
                table: "CarClasses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceCoeficients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    DaysCount = table.Column<int>(type: "int", nullable: false),
                    Coefficient = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceCoeficients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceCoeficients_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentAddedOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentId = table.Column<int>(type: "int", nullable: false),
                    RentAdditionalOptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentAddedOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentAddedOptions_RentAdditionalOptions_RentAdditionalOptionId",
                        column: x => x.RentAdditionalOptionId,
                        principalTable: "RentAdditionalOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentAddedOptions_Rents_RentId",
                        column: x => x.RentId,
                        principalTable: "Rents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceWorker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceWorker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmitions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CustomerId",
                table: "AspNetUsers",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ManagerId",
                table: "AspNetUsers",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ServiceWorkerId",
                table: "AspNetUsers",
                column: "ServiceWorkerId",
                unique: true,
                filter: "[ServiceWorkerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_CustomerId",
                table: "Rents",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_ManagerId",
                table: "Rents",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionReports_ManagerId",
                table: "ConditionReports",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_CarServiceReports_ServiceWorkerId",
                table: "CarServiceReports",
                column: "ServiceWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceCoeficients_CarId",
                table: "PriceCoeficients",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_RentAddedOptions_RentAdditionalOptionId",
                table: "RentAddedOptions",
                column: "RentAdditionalOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_RentAddedOptions_RentId",
                table: "RentAddedOptions",
                column: "RentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Customer_CustomerId",
                table: "AspNetUsers",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Manager_ManagerId",
                table: "AspNetUsers",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ServiceWorker_ServiceWorkerId",
                table: "AspNetUsers",
                column: "ServiceWorkerId",
                principalTable: "ServiceWorker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brand_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarClasses_CarClassId",
                table: "Cars",
                column: "CarClassId",
                principalTable: "CarClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarStatuses_CarStatusId",
                table: "Cars",
                column: "CarStatusId",
                principalTable: "CarStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars",
                column: "CarTypeId",
                principalTable: "CarTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Engines_EngineId",
                table: "Cars",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Fuels_FuelId",
                table: "Cars",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Locations_LocationId",
                table: "Cars",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Transmitions_TransmissionId",
                table: "Cars",
                column: "TransmissionId",
                principalTable: "Transmitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServiceReports_CarServices_CarServiceId",
                table: "CarServiceReports",
                column: "CarServiceId",
                principalTable: "CarServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServiceReports_ConditionReports_ConditionReportId",
                table: "CarServiceReports",
                column: "ConditionReportId",
                principalTable: "ConditionReports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServiceReports_ServiceWorker_ServiceWorkerId",
                table: "CarServiceReports",
                column: "ServiceWorkerId",
                principalTable: "ServiceWorker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReports_Cars_CarId",
                table: "ConditionReports",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReports_ConditionMarks_InteriorConditionId",
                table: "ConditionReports",
                column: "InteriorConditionId",
                principalTable: "ConditionMarks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReports_Manager_ManagerId",
                table: "ConditionReports",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Cities_CityId",
                table: "Locations",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Countries_CountryId",
                table: "Locations",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentRentAdditionalOption_RentAdditionalOptions_AdditionalOptionsId",
                table: "RentRentAdditionalOption",
                column: "AdditionalOptionsId",
                principalTable: "RentAdditionalOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentRentAdditionalOption_Rents_RentsId",
                table: "RentRentAdditionalOption",
                column: "RentsId",
                principalTable: "Rents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Cars_CarId",
                table: "Rents",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Customer_CustomerId",
                table: "Rents",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Manager_ManagerId",
                table: "Rents",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_RentStatuses_RentStatusId",
                table: "Rents",
                column: "RentStatusId",
                principalTable: "RentStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Cars_CarId",
                table: "Reviews",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Customer_CustomerId",
                table: "Reviews",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Customer_CustomerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Manager_ManagerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ServiceWorker_ServiceWorkerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brand_BrandId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarClasses_CarClassId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarStatuses_CarStatusId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Engines_EngineId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Fuels_FuelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Locations_LocationId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Transmitions_TransmissionId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServiceReports_CarServices_CarServiceId",
                table: "CarServiceReports");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServiceReports_ConditionReports_ConditionReportId",
                table: "CarServiceReports");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServiceReports_ServiceWorker_ServiceWorkerId",
                table: "CarServiceReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReports_Cars_CarId",
                table: "ConditionReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReports_ConditionMarks_InteriorConditionId",
                table: "ConditionReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReports_Manager_ManagerId",
                table: "ConditionReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Cities_CityId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Countries_CountryId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_RentRentAdditionalOption_RentAdditionalOptions_AdditionalOptionsId",
                table: "RentRentAdditionalOption");

            migrationBuilder.DropForeignKey(
                name: "FK_RentRentAdditionalOption_Rents_RentsId",
                table: "RentRentAdditionalOption");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Cars_CarId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Customer_CustomerId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Manager_ManagerId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_RentStatuses_RentStatusId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Cars_CarId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Customer_CustomerId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "CarStatuses");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "PriceCoeficients");

            migrationBuilder.DropTable(
                name: "RentAddedOptions");

            migrationBuilder.DropTable(
                name: "ServiceWorker");

            migrationBuilder.DropTable(
                name: "Transmitions");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CustomerId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ManagerId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ServiceWorkerId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentStatuses",
                table: "RentStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rents",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_CustomerId",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_ManagerId",
                table: "Rents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentAdditionalOptions",
                table: "RentAdditionalOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fuels",
                table: "Fuels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engines",
                table: "Engines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConditionReports",
                table: "ConditionReports");

            migrationBuilder.DropIndex(
                name: "IX_ConditionReports_ManagerId",
                table: "ConditionReports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConditionMarks",
                table: "ConditionMarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarTypes",
                table: "CarTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarServices",
                table: "CarServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarServiceReports",
                table: "CarServiceReports");

            migrationBuilder.DropIndex(
                name: "IX_CarServiceReports_ServiceWorkerId",
                table: "CarServiceReports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_BrandId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarClasses",
                table: "CarClasses");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ServiceWorkerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "Coordinate",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "ServiceWorkerId",
                table: "CarServiceReports");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "RentStatuses",
                newName: "RentStatus");

            migrationBuilder.RenameTable(
                name: "Rents",
                newName: "Rent");

            migrationBuilder.RenameTable(
                name: "RentAdditionalOptions",
                newName: "RentAdditionalOption");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "Fuels",
                newName: "Fuel");

            migrationBuilder.RenameTable(
                name: "Engines",
                newName: "Engine");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "ConditionReports",
                newName: "ConditionReport");

            migrationBuilder.RenameTable(
                name: "ConditionMarks",
                newName: "ConditionMark");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameTable(
                name: "CarTypes",
                newName: "CarType");

            migrationBuilder.RenameTable(
                name: "CarServices",
                newName: "CarService");

            migrationBuilder.RenameTable(
                name: "CarServiceReports",
                newName: "CarServiceReport");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Car");

            migrationBuilder.RenameTable(
                name: "CarClasses",
                newName: "CarClass");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Review",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_CarId",
                table: "Review",
                newName: "IX_Review_CarId");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Rent",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Rents_RentStatusId",
                table: "Rent",
                newName: "IX_Rent_RentStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Rents_CarId",
                table: "Rent",
                newName: "IX_Rent_CarId");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_CountryId",
                table: "Location",
                newName: "IX_Location_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_CityId",
                table: "Location",
                newName: "IX_Location_CityId");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "ConditionReport",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionReports_InteriorConditionId",
                table: "ConditionReport",
                newName: "IX_ConditionReport_InteriorConditionId");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionReports_CarId",
                table: "ConditionReport",
                newName: "IX_ConditionReport_CarId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServiceReports_ConditionReportId",
                table: "CarServiceReport",
                newName: "IX_CarServiceReport_ConditionReportId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServiceReports_CarServiceId",
                table: "CarServiceReport",
                newName: "IX_CarServiceReport_CarServiceId");

            migrationBuilder.RenameColumn(
                name: "TransmissionId",
                table: "Car",
                newName: "TransmitionId");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Car",
                newName: "Brand");

            migrationBuilder.RenameColumn(
                name: "CarStatusId",
                table: "Car",
                newName: "StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_TransmissionId",
                table: "Car",
                newName: "IX_Car_TransmitionId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_LocationId",
                table: "Car",
                newName: "IX_Car_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_FuelId",
                table: "Car",
                newName: "IX_Car_FuelId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_EngineId",
                table: "Car",
                newName: "IX_Car_EngineId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CarTypeId",
                table: "Car",
                newName: "IX_Car_CarTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CarStatusId",
                table: "Car",
                newName: "IX_Car_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CarClassId",
                table: "Car",
                newName: "IX_Car_CarClassId");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Review",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Rent",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "ConditionReport",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentStatus",
                table: "RentStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rent",
                table: "Rent",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentAdditionalOption",
                table: "RentAdditionalOption",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fuel",
                table: "Fuel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engine",
                table: "Engine",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConditionReport",
                table: "ConditionReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConditionMark",
                table: "ConditionMark",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarType",
                table: "CarType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarService",
                table: "CarService",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarServiceReport",
                table: "CarServiceReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarClass",
                table: "CarClass",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PriceCoeficient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    Coeficient = table.Column<double>(type: "float", nullable: false),
                    DaysCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceCoeficient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceCoeficient_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmition", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId1",
                table: "Review",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_UserId1",
                table: "Rent",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionReport_UserId1",
                table: "ConditionReport",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_PriceCoeficient_CarId",
                table: "PriceCoeficient",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_CarClass_CarClassId",
                table: "Car",
                column: "CarClassId",
                principalTable: "CarClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_CarType_CarTypeId",
                table: "Car",
                column: "CarTypeId",
                principalTable: "CarType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Engine_EngineId",
                table: "Car",
                column: "EngineId",
                principalTable: "Engine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Fuel_FuelId",
                table: "Car",
                column: "FuelId",
                principalTable: "Fuel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Location_LocationId",
                table: "Car",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Status_StatusId",
                table: "Car",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Transmition_TransmitionId",
                table: "Car",
                column: "TransmitionId",
                principalTable: "Transmition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServiceReport_CarService_CarServiceId",
                table: "CarServiceReport",
                column: "CarServiceId",
                principalTable: "CarService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServiceReport_ConditionReport_ConditionReportId",
                table: "CarServiceReport",
                column: "ConditionReportId",
                principalTable: "ConditionReport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReport_AspNetUsers_UserId1",
                table: "ConditionReport",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReport_Car_CarId",
                table: "ConditionReport",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReport_ConditionMark_InteriorConditionId",
                table: "ConditionReport",
                column: "InteriorConditionId",
                principalTable: "ConditionMark",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_City_CityId",
                table: "Location",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Country_CountryId",
                table: "Location",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_AspNetUsers_UserId1",
                table: "Rent",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Car_CarId",
                table: "Rent",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_RentStatus_RentStatusId",
                table: "Rent",
                column: "RentStatusId",
                principalTable: "RentStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentRentAdditionalOption_Rent_RentsId",
                table: "RentRentAdditionalOption",
                column: "RentsId",
                principalTable: "Rent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentRentAdditionalOption_RentAdditionalOption_AdditionalOptionsId",
                table: "RentRentAdditionalOption",
                column: "AdditionalOptionsId",
                principalTable: "RentAdditionalOption",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_UserId1",
                table: "Review",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Car_CarId",
                table: "Review",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
