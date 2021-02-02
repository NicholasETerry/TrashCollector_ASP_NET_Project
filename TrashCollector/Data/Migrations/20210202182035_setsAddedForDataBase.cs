using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class setsAddedForDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdd2039a-cb6d-4bb0-8e51-7fa8f81e393a");

            migrationBuilder.CreateTable(
                name: "CalenderTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduledPickUp = table.Column<DateTime>(nullable: false),
                    SpecialPickUp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalenderTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomersTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    PaymentId = table.Column<int>(nullable: false),
                    AmountOwed = table.Column<double>(nullable: false),
                    CalendarId = table.Column<int>(nullable: false),
                    ScheduledPickUp = table.Column<DateTime>(nullable: false),
                    SpecialPickUp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    ConfirmPickUp = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountOwed = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8f1bb51-7b96-4aaa-8762-fcccfbaf96f0", "9c58269e-abc4-4fc1-8e0d-b32198d5c314", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalenderTable");

            migrationBuilder.DropTable(
                name: "CustomersTable");

            migrationBuilder.DropTable(
                name: "EmployeesTable");

            migrationBuilder.DropTable(
                name: "PaymentTable");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8f1bb51-7b96-4aaa-8762-fcccfbaf96f0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdd2039a-cb6d-4bb0-8e51-7fa8f81e393a", "ee54bf5a-97d7-492d-b8bf-524da2889a41", "Admin", "ADMIN" });
        }
    }
}
