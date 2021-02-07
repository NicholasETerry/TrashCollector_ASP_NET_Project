using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class dataupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "311ef3d5-abeb-498d-9895-c831c1ef4aac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed1ffecf-1692-4dbc-85b2-bf559b9251e4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f85fdf8c-d67e-4eb3-8e7c-ae7b473f7beb", "1ee46db5-d7a8-4f2b-8c51-65c2231b6c8b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "219f1a6f-40da-4ef2-a5d0-48db74a694d3", "202a7ccc-3fb4-4692-99cb-0a3b73abc6a0", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "219f1a6f-40da-4ef2-a5d0-48db74a694d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f85fdf8c-d67e-4eb3-8e7c-ae7b473f7beb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "311ef3d5-abeb-498d-9895-c831c1ef4aac", "0562d5b6-976d-4c9f-9730-7dd4c2b476ad", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed1ffecf-1692-4dbc-85b2-bf559b9251e4", "0a58b6f3-a8d4-4a51-9b7a-e2251788d5d6", "Employee", "EMPLOYEE" });
        }
    }
}
