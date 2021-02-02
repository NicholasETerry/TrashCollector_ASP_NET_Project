using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class dbsetAttributesChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8f1bb51-7b96-4aaa-8762-fcccfbaf96f0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "457ed4a5-5174-4dfc-8f67-7749066e69d9", "975c73a5-4d5f-4ef1-81a9-7ee5e9427627", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "457ed4a5-5174-4dfc-8f67-7749066e69d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8f1bb51-7b96-4aaa-8762-fcccfbaf96f0", "9c58269e-abc4-4fc1-8e0d-b32198d5c314", "Admin", "ADMIN" });
        }
    }
}
