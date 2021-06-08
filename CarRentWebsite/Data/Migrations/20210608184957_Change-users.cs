using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebsite.Data.Migrations
{
    public partial class Changeusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Cars_Transmitions_TransmissionId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServiceReports_ServiceWorker_ServiceWorkerId",
                table: "CarServiceReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReports_Manager_ManagerId",
                table: "ConditionReports");

            migrationBuilder.DropForeignKey(
                name: "FK_PriceCoeficients_Cars_CarId",
                table: "PriceCoeficients");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Customer_CustomerId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Manager_ManagerId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Customer_CustomerId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "ServiceWorker");

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
                name: "PK_Transmitions",
                table: "Transmitions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceCoeficients",
                table: "PriceCoeficients");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ServiceWorkerId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Transmitions",
                newName: "Transmissions");

            migrationBuilder.RenameTable(
                name: "PriceCoeficients",
                newName: "PriceCoefficients");

            migrationBuilder.RenameIndex(
                name: "IX_PriceCoeficients_CarId",
                table: "PriceCoefficients",
                newName: "IX_PriceCoefficients_CarId");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ManagerId",
                table: "Rents",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Rents",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ManagerId",
                table: "ConditionReports",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ServiceWorkerId",
                table: "CarServiceReports",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transmissions",
                table: "Transmissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceCoefficients",
                table: "PriceCoefficients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Transmissions_TransmissionId",
                table: "Cars",
                column: "TransmissionId",
                principalTable: "Transmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServiceReports_AspNetUsers_ServiceWorkerId",
                table: "CarServiceReports",
                column: "ServiceWorkerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionReports_AspNetUsers_ManagerId",
                table: "ConditionReports",
                column: "ManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PriceCoefficients_Cars_CarId",
                table: "PriceCoefficients",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_AspNetUsers_CustomerId",
                table: "Rents",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_AspNetUsers_ManagerId",
                table: "Rents",
                column: "ManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_CustomerId",
                table: "Reviews",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Transmissions_TransmissionId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServiceReports_AspNetUsers_ServiceWorkerId",
                table: "CarServiceReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionReports_AspNetUsers_ManagerId",
                table: "ConditionReports");

            migrationBuilder.DropForeignKey(
                name: "FK_PriceCoefficients_Cars_CarId",
                table: "PriceCoefficients");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_AspNetUsers_CustomerId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_AspNetUsers_ManagerId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_CustomerId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transmissions",
                table: "Transmissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceCoefficients",
                table: "PriceCoefficients");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Transmissions",
                newName: "Transmitions");

            migrationBuilder.RenameTable(
                name: "PriceCoefficients",
                newName: "PriceCoeficients");

            migrationBuilder.RenameIndex(
                name: "IX_PriceCoefficients_CarId",
                table: "PriceCoeficients",
                newName: "IX_PriceCoeficients_CarId");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "Rents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Rents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "ConditionReports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceWorkerId",
                table: "CarServiceReports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transmitions",
                table: "Transmitions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceCoeficients",
                table: "PriceCoeficients",
                column: "Id");

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
                name: "FK_Cars_Transmitions_TransmissionId",
                table: "Cars",
                column: "TransmissionId",
                principalTable: "Transmitions",
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
                name: "FK_ConditionReports_Manager_ManagerId",
                table: "ConditionReports",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PriceCoeficients_Cars_CarId",
                table: "PriceCoeficients",
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
                name: "FK_Reviews_Customer_CustomerId",
                table: "Reviews",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
