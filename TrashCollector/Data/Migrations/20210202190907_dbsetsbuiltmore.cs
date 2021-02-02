using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class dbsetsbuiltmore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dda53c3-c61a-48c6-bf29-9ac273f20c31");

            migrationBuilder.AddColumn<int>(
                name: "CalendarId",
                table: "EmployeesTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "EmployeesTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "025735a6-8693-4a45-85ed-aef11a7e8362", "f77cf4e3-635e-4849-a3f0-9ff03512e87d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "025735a6-8693-4a45-85ed-aef11a7e8362");

            migrationBuilder.DropColumn(
                name: "CalendarId",
                table: "EmployeesTable");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "EmployeesTable");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0dda53c3-c61a-48c6-bf29-9ac273f20c31", "bc7c15af-fd2a-4c61-8f0b-cd695b320a22", "Admin", "ADMIN" });
        }
    }
}
