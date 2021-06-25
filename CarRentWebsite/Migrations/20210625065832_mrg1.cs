using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebsite.Migrations
{
    public partial class mrg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarServices", x => x.Id);
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
                name: "CarTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConditionMarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionMarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelCapacity = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Torque = table.Column<int>(type: "int", nullable: false),
                    WinCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentAdditionalOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentAdditionalOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
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
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceWorkerInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegisterNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatsCount = table.Column<int>(type: "int", nullable: false),
                    TrunkSize = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    TransmissionId = table.Column<int>(type: "int", nullable: false),
                    CarStatusId = table.Column<int>(type: "int", nullable: false),
                    CarTypeId = table.Column<int>(type: "int", nullable: false),
                    CarClassId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KilometersDriven = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_CarClasses_CarClassId",
                        column: x => x.CarClassId,
                        principalTable: "CarClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_CarStatuses_CarStatusId",
                        column: x => x.CarStatusId,
                        principalTable: "CarStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_CarTypes_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "CarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConditionReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FuelVolume = table.Column<int>(type: "int", nullable: false),
                    CarMileage = table.Column<int>(type: "int", nullable: false),
                    IsCritical = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InteriorConditionId = table.Column<int>(type: "int", nullable: false),
                    LpcConditionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionReports_ApplicationUsers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConditionReports_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConditionReports_ConditionMarks_InteriorConditionId",
                        column: x => x.InteriorConditionId,
                        principalTable: "ConditionMarks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConditionReports_ConditionMarks_LpcConditionId",
                        column: x => x.LpcConditionId,
                        principalTable: "ConditionMarks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PriceCoefficients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    DaysCount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceCoefficients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceCoefficients_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    RentStatusId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ManagerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rents_ApplicationUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rents_ApplicationUsers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rents_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rents_RentStatuses_RentStatusId",
                        column: x => x.RentStatusId,
                        principalTable: "RentStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mark = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_ApplicationUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarServiceReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    ConditionReportId = table.Column<int>(type: "int", nullable: false),
                    CarServiceId = table.Column<int>(type: "int", nullable: false),
                    ServiceWorkerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarServiceReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarServiceReports_ApplicationUsers_ServiceWorkerId",
                        column: x => x.ServiceWorkerId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarServiceReports_CarServices_CarServiceId",
                        column: x => x.CarServiceId,
                        principalTable: "CarServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarServiceReports_ConditionReports_ConditionReportId",
                        column: x => x.ConditionReportId,
                        principalTable: "ConditionReports",
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
                name: "RentRentAdditionalOption",
                columns: table => new
                {
                    AdditionalOptionsId = table.Column<int>(type: "int", nullable: false),
                    RentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentRentAdditionalOption", x => new { x.AdditionalOptionsId, x.RentsId });
                    table.ForeignKey(
                        name: "FK_RentRentAdditionalOption_RentAdditionalOptions_AdditionalOptionsId",
                        column: x => x.AdditionalOptionsId,
                        principalTable: "RentAdditionalOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentRentAdditionalOption_Rents_RentsId",
                        column: x => x.RentsId,
                        principalTable: "Rents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 14, "Full-size SUV" },
                    { 13, "Mid-size SUV" },
                    { 12, "Mini SUV" },
                    { 10, "Compact minivan" },
                    { 7, "Mid-size car" },
                    { 8, "Hatchback" },
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
                    { 3, "Repair" },
                    { 1, "Idle" },
                    { 2, "Rent" }
                });

            migrationBuilder.InsertData(
                table: "CarTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Luxury" },
                    { 1, "Econom" },
                    { 2, "Business" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dnipro" },
                    { 2, "Lviv" },
                    { 3, "Kharkiw" },
                    { 4, "Kyiv" }
                });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "FuelCapacity", "Name", "Power", "Torque", "WinCode" },
                values: new object[,]
                {
                    { 1, 6, "Engine1", 120, 45, "ASD45ufa95" },
                    { 2, 6, "Engine2", 120, 45, "ASttrra95" },
                    { 3, 6, "Engine3", 120, 45, "1123456" },
                    { 4, 6, "Engine4", 120, 45, "9034hh5" }
                });

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Hybrid" });

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Petrol" },
                    { 2, "Diesel" },
                    { 3, "Electric" },
                    { 5, "Propane" }
                });

            migrationBuilder.InsertData(
                table: "RentAdditionalOptions",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 3, "Phone Holder", 10.0 },
                    { 1, "Child Chair", 50.0 },
                    { 2, "Gps", 25.0 }
                });

            migrationBuilder.InsertData(
                table: "RentStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Created" },
                    { 2, "Accepted" },
                    { 3, "Started" },
                    { 4, "Finished" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "ServiceWorker" },
                    { 1, "Customer" },
                    { 2, "Manager" },
                    { 3, "Admin" }
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

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "CarClassId", "CarStatusId", "CarTypeId", "Description", "EngineId", "FuelId", "ImageUrl", "KilometersDriven", "LocationId", "Model", "RegisterDate", "RegisterNumber", "SeatsCount", "TransmissionId", "TrunkSize" },
                values: new object[,]
                {
                    { 3, 1, 5, 1, 3, "Car description2...", 4, 1, "http://bm.img.com.ua/berlin/storage/600x500/0/d2/0a259e6b0be7ef8067228baf64361d20.jpg", 300032, 2, "525", new DateTime(2021, 6, 25, 9, 58, 32, 245, DateTimeKind.Local).AddTicks(4296), "AE5544KE", 4, 3, 80 },
                    { 2, 3, 4, 1, 2, "Car description2...", 3, 1, "https://www.ixbt.com/img/n1/news/2021/0/6/lhd-model-3-social_large.png", 3234, 4, "Model S", new DateTime(2021, 6, 25, 9, 58, 32, 245, DateTimeKind.Local).AddTicks(4259), "AA7104MT", 4, 2, 60 },
                    { 4, 1, 5, 1, 3, "Car description2...", 4, 1, "data:image/jpeg;base64,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", 3343, 4, "325", new DateTime(2021, 6, 25, 9, 58, 32, 245, DateTimeKind.Local).AddTicks(4303), "AE5544KE", 4, 3, 60 },
                    { 1, 1, 2, 1, 1, "Car description...", 2, 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBjOLV4oC85vIevarurD4-EoGNKKyqKVY74w&usqp=CAU", 324234, 1, "AMG G3", new DateTime(2021, 6, 25, 9, 58, 32, 242, DateTimeKind.Local).AddTicks(9772), "BO7104RT", 4, 1, 40 }
                });

            migrationBuilder.InsertData(
                table: "PriceCoefficients",
                columns: new[] { "Id", "CarId", "DaysCount", "Price" },
                values: new object[,]
                {
                    { 9, 3, 4, 150.0 },
                    { 10, 3, 7, 120.0 },
                    { 11, 3, 14, 90.0 },
                    { 12, 3, 21, 80.0 },
                    { 5, 2, 4, 90.0 },
                    { 6, 2, 7, 70.0 },
                    { 7, 2, 14, 60.0 },
                    { 8, 2, 21, 40.0 },
                    { 13, 4, 4, 70.0 },
                    { 14, 4, 7, 60.0 },
                    { 15, 4, 14, 50.0 },
                    { 16, 4, 21, 40.0 },
                    { 1, 1, 4, 200.0 },
                    { 2, 1, 7, 150.0 },
                    { 3, 1, 14, 90.0 },
                    { 4, 1, 21, 70.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_RoleId",
                table: "ApplicationUsers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarClassId",
                table: "Cars",
                column: "CarClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarStatusId",
                table: "Cars",
                column: "CarStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarTypeId",
                table: "Cars",
                column: "CarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_EngineId",
                table: "Cars",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelId",
                table: "Cars",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_LocationId",
                table: "Cars",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TransmissionId",
                table: "Cars",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_CarServiceReports_CarServiceId",
                table: "CarServiceReports",
                column: "CarServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CarServiceReports_ConditionReportId",
                table: "CarServiceReports",
                column: "ConditionReportId");

            migrationBuilder.CreateIndex(
                name: "IX_CarServiceReports_ServiceWorkerId",
                table: "CarServiceReports",
                column: "ServiceWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionReports_CarId",
                table: "ConditionReports",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionReports_InteriorConditionId",
                table: "ConditionReports",
                column: "InteriorConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionReports_LpcConditionId",
                table: "ConditionReports",
                column: "LpcConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionReports_ManagerId",
                table: "ConditionReports",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityId",
                table: "Locations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceCoefficients_CarId",
                table: "PriceCoefficients",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_RentAddedOptions_RentAdditionalOptionId",
                table: "RentAddedOptions",
                column: "RentAdditionalOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_RentAddedOptions_RentId",
                table: "RentAddedOptions",
                column: "RentId");

            migrationBuilder.CreateIndex(
                name: "IX_RentRentAdditionalOption_RentsId",
                table: "RentRentAdditionalOption",
                column: "RentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_CarId",
                table: "Rents",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_CustomerId",
                table: "Rents",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_ManagerId",
                table: "Rents",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_RentStatusId",
                table: "Rents",
                column: "RentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CarId",
                table: "Reviews",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarServiceReports");

            migrationBuilder.DropTable(
                name: "PriceCoefficients");

            migrationBuilder.DropTable(
                name: "RentAddedOptions");

            migrationBuilder.DropTable(
                name: "RentRentAdditionalOption");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "CarServices");

            migrationBuilder.DropTable(
                name: "ConditionReports");

            migrationBuilder.DropTable(
                name: "RentAdditionalOptions");

            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "ConditionMarks");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "RentStatuses");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "CarClasses");

            migrationBuilder.DropTable(
                name: "CarStatuses");

            migrationBuilder.DropTable(
                name: "CarTypes");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Transmissions");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
