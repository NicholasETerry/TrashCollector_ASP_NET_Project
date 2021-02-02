using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class dbsetchangs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "025735a6-8693-4a45-85ed-aef11a7e8362");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e48efe60-bbbc-4799-88be-609fab8954a5", "35eea2c6-0a83-4999-9ad2-17c55f910a77", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e48efe60-bbbc-4799-88be-609fab8954a5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "025735a6-8693-4a45-85ed-aef11a7e8362", "f77cf4e3-635e-4849-a3f0-9ff03512e87d", "Admin", "ADMIN" });
        }
    }
}
