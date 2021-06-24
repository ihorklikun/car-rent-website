using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebsite.Migrations
{
    public partial class mgr : Migration
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
                    CustomerInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    InteriorConditionId = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriceCoefficients",
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
                    { 2, "Business" },
                    { 1, "Econom" }
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
                    { 1, 6, "Engine1", 120, 45, "ASD45ufa95" },
                    { 2, 6, "Engine2", 120, 45, "ASttrra95" }
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
                table: "Fuels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Propane" },
                    { 3, "Electric" },
                    { 4, "Hybrid" },
                    { 1, "Petrol" },
                    { 2, "Diesel" }
                });

            migrationBuilder.InsertData(
                table: "RentAdditionalOptions",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Child Chair", 50.0 },
                    { 2, "Gps", 25.0 },
                    { 3, "Phone Holder", 10.0 }
                });

            migrationBuilder.InsertData(
                table: "RentStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Finished" },
                    { 1, "Created" },
                    { 2, "Accepted" },
                    { 3, "Started" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Customer" },
                    { 2, "Manager" },
                    { 3, "Admin" },
                    { 4, "ServiceWorker" }
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
                table: "Cars",
                columns: new[] { "Id", "BrandId", "CarClassId", "CarStatusId", "CarTypeId", "Description", "EngineId", "FuelId", "ImageUrl", "KilometersDriven", "Model", "RegisterDate", "RegisterNumber", "SeatsCount", "TransmissionId", "TrunkSize" },
                values: new object[,]
                {
                    { 1, 1, 2, 1, 1, "Car description...", 2, 1, "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", 0, null, new DateTime(2021, 6, 23, 16, 39, 37, 55, DateTimeKind.Local).AddTicks(2092), "BO7104RT", 4, 1, 40 },
                    { 2, 3, 4, 1, 2, "Car description2...", 3, 1, "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", 0, null, new DateTime(2021, 6, 23, 16, 39, 37, 57, DateTimeKind.Local).AddTicks(3565), "AA7104MT", 4, 2, 60 },
                    { 3, 1, 5, 1, 3, "Car description2...", 4, 1, "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", 0, null, new DateTime(2021, 6, 23, 16, 39, 37, 57, DateTimeKind.Local).AddTicks(3598), "AE5544KE", 4, 3, 80 },
                    { 4, 1, 5, 1, 3, "Car description2...", 4, 1, "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg", 0, null, new DateTime(2021, 6, 23, 16, 39, 37, 57, DateTimeKind.Local).AddTicks(3605), "AE5544KE", 4, 3, 60 }
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
                name: "IX_ConditionReports_ManagerId",
                table: "ConditionReports",
                column: "ManagerId");

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
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

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
                name: "Transmissions");
        }
    }
}
