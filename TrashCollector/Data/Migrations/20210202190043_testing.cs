using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f742922-f826-4fde-a4d9-13cb49e6db14");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0dda53c3-c61a-48c6-bf29-9ac273f20c31", "bc7c15af-fd2a-4c61-8f0b-cd695b320a22", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dda53c3-c61a-48c6-bf29-9ac273f20c31");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f742922-f826-4fde-a4d9-13cb49e6db14", "31f22e12-4517-43b3-a765-492c412706c6", "Admin", "ADMIN" });
        }
    }
}
